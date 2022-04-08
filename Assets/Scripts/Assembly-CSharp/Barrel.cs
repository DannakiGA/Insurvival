using UnityEngine;

public class Barrel : EnemyBase
{
	public GameObject DestroySprite;

	private void Start()
	{
		ThisSprite = GetComponent<SpriteRenderer>();
		EnemyAudio = GetComponent<AudioSource>();
		EnemyAnimator = GetComponent<Animator>();
	}

	public override void Hitting(int Value)
	{
		Health -= Value;
		if (Health < 1)
		{
			Object.Instantiate(DestroySprite, base.transform.position, Quaternion.identity);
			Parameters.exp += 4f;
			Object.Destroy(base.gameObject);
		}
	}
}
