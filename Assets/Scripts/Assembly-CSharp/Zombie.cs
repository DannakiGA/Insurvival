using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : EnemyBase
{
	[HideInInspector]
	public float DistanceToPlayer;

	public float BiteTimeBetween;

	public float PainTime;

	public int AddedDamage;

	public GameObject DestroySprite;

	[HideInInspector]
	public bool CanBite = true;

	[HideInInspector]
	public bool isHere;

	[HideInInspector]
	public bool isPain;

	private NavMeshAgent Agent;

	private void Start()
	{
		ThisSprite = GetComponent<SpriteRenderer>();
		EnemyAudio = GetComponent<AudioSource>();
		EnemyAnimator = GetComponent<Animator>();
		Agent = GetComponent<NavMeshAgent>();
		if (!referenceCamera)
		{
			referenceCamera = Camera.main;
		}
		InformerScript informerScript = (InformerScript)Object.FindObjectOfType(typeof(InformerScript));
		GetInfo = informerScript.GetComponent<InformerScript>();
	}

	public override void Hitting(int Value)
	{
		StartCoroutine(Hit());
		Health -= Value;
		if (Health < 1)
		{
			Object.Instantiate(DestroySprite, base.transform.position, Quaternion.identity);
			Parameters.exp += 12f;
			Object.Destroy(base.gameObject);
		}
	}

	private IEnumerator Hit()
	{
		StopCoroutine("Bite");
		Agent.enabled = false;
		isPain = true;
		EnemyAnimator.SetBool("isPain", true);
		HitColorChanger();
		EnemyAudio.PlayOneShot(Pain[Random.Range(0, Pain.Length)]);
		yield return new WaitForSeconds(PainTime);
		EnemyAnimator.SetBool("isPain", false);
		isPain = false;
	}

	private IEnumerator Bite()
	{
		CanBite = false;
		Agent.enabled = false;
		EnemyAnimator.SetTrigger("isBite");
		EnemyAudio.PlayOneShot(Attack[Random.Range(0, Attack.Length)]);
		GetInfo.GetHit(2 + AddedDamage);
		yield return new WaitForSeconds(BiteTimeBetween);
		CanBite = true;
	}

	private void Update()
	{
		DistanceToPlayer = Vector3.Distance(referenceCamera.transform.position, base.transform.position);
		EnemyAudio.volume = Settings.Sound;
		if (DistanceToPlayer < 85f && !isHere)
		{
			int num = 2048;
			num = ~num;
			Vector3 vector = new Vector3(base.transform.position.x, base.transform.position.y + 0.6f, base.transform.position.z);
			Vector3 vector2 = new Vector3(referenceCamera.transform.position.x, referenceCamera.transform.position.y - 0.4f, referenceCamera.transform.position.z);
			RaycastHit hitInfo;
			if (Physics.Raycast(vector, vector2 - vector, out hitInfo, 85f, num) && hitInfo.collider != null && hitInfo.collider.tag == "Player")
			{
				isHere = true;
			}
		}
		if (isHere)
		{
			if (Agent.enabled)
			{
				Agent.destination = referenceCamera.transform.position;
			}
			if (DistanceToPlayer > 84f)
			{
				EnemyAnimator.SetBool("isWalk", false);
				Agent.enabled = false;
			}
			if (DistanceToPlayer < 84f && DistanceToPlayer > 2f && !isPain)
			{
				EnemyAnimator.SetBool("isWalk", true);
				Agent.enabled = true;
			}
			if (DistanceToPlayer < 2.3f && !isPain && CanBite)
			{
				StartCoroutine(Bite());
			}
		}
	}
}
