using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class BotWeapon : EnemyBase
{
	[HideInInspector]
	public float DistanceToPlayer;

	public float BiteTimeBetween;

	public float ShootDistance;

	public GameObject Bullet;

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
			Parameters.exp += 18f;
			Object.Destroy(base.gameObject);
		}
	}

	public void Shooting()
	{
		EnemyAudio.PlayOneShot(Attack[Random.Range(0, Attack.Length)]);
		Object.Instantiate(Bullet, new Vector3(base.transform.position.x, base.transform.position.y + 0.7f, base.transform.position.z), Quaternion.identity);
	}

	private IEnumerator Bite()
	{
		CanBite = !CanBite;
		Agent.enabled = false;
		EnemyAnimator.SetBool("isWalk", false);
		EnemyAnimator.SetTrigger("isShoot");
		yield return new WaitForSeconds(BiteTimeBetween);
		CanBite = !CanBite;
	}

	private void Update()
	{
		DistanceToPlayer = Vector3.Distance(referenceCamera.transform.position, base.transform.position);
		EnemyAudio.volume = Settings.Sound;
		if (DistanceToPlayer < 65.2f && !isHere)
		{
			int num = 2048;
			num = ~num;
			Vector3 vector = new Vector3(base.transform.position.x, base.transform.position.y + 0.6f, base.transform.position.z);
			Vector3 vector2 = new Vector3(referenceCamera.transform.position.x, referenceCamera.transform.position.y - 0.4f, referenceCamera.transform.position.z);
			RaycastHit hitInfo;
			if (Physics.Raycast(vector, vector2 - vector, out hitInfo, 65f, num) && hitInfo.collider != null && hitInfo.collider.tag == "Player")
			{
				isHere = true;
			}
		}
		if (!isHere)
		{
			return;
		}
		if (Agent.enabled)
		{
			Agent.destination = referenceCamera.transform.position;
		}
		if (DistanceToPlayer > 65f)
		{
			EnemyAnimator.SetBool("isWalk", false);
			Agent.enabled = false;
		}
		if (DistanceToPlayer < 65f && DistanceToPlayer > ShootDistance)
		{
			EnemyAnimator.SetBool("isWalk", true);
			Agent.enabled = true;
		}
		if (DistanceToPlayer < ShootDistance)
		{
			int num2 = 2048;
			num2 = ~num2;
			Vector3 vector3 = new Vector3(base.transform.position.x, base.transform.position.y + 0.6f, base.transform.position.z);
			Vector3 vector4 = new Vector3(referenceCamera.transform.position.x, referenceCamera.transform.position.y - 0.4f, referenceCamera.transform.position.z);
			RaycastHit hitInfo2;
			if (Physics.Raycast(vector3, vector4 - vector3, out hitInfo2, ShootDistance + 0.2f, num2) && hitInfo2.collider != null && hitInfo2.collider.tag == "Player" && CanBite)
			{
				StartCoroutine(Bite());
			}
		}
	}
}
