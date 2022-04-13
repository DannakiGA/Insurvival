using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class BotMelee : EnemyBase
{
	[HideInInspector]
	public float DistanceToPlayer;

	public float BiteTimeBetween;

	public GameObject DestroySprite;

	[HideInInspector]
	public bool CanBite = true;

	[HideInInspector]
	public bool isHere;

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
	}

	public override void Hitting(int Value)
	{
		EnemyAudio.PlayOneShot(Pain[Random.Range(0, Pain.Length)]);
		Health -= Value;
		HitColorChanger();
		if (Health < 1)
		{
			Object.Instantiate(DestroySprite, base.transform.position, Quaternion.identity);
			//Parameters.exp += 15f;
			Object.Destroy(base.gameObject);
		}
	}

	private IEnumerator Bite()
	{
		CanBite = !CanBite;
		Agent.enabled = false;
		EnemyAnimator.SetTrigger("isBite");
		EnemyAudio.PlayOneShot(Attack[Random.Range(0, Attack.Length)]);
		GruntSource.Get().SetHealthValue = -5;
		yield return new WaitForSeconds(BiteTimeBetween);
		CanBite = !CanBite;
	}

	private void Update()
	{
		DistanceToPlayer = Vector3.Distance(referenceCamera.transform.position, base.transform.position);
		EnemyAudio.volume = Settings.Sound;
		if (DistanceToPlayer < 85.2f && !isHere)
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
			if (DistanceToPlayer > 85f)
			{
				EnemyAnimator.SetBool("isWalk", false);
				Agent.enabled = false;
			}
			if (DistanceToPlayer < 85f && DistanceToPlayer > 2f)
			{
				EnemyAnimator.SetBool("isWalk", true);
				Agent.enabled = true;
			}
			if (DistanceToPlayer < 2.3f && CanBite)
			{
				StartCoroutine(Bite());
			}
		}
	}
}
