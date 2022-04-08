using System.Collections;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
	public Color StandartColor;

	public Color HitColor;

	public int Health;

	public AudioClip[] Pain;

	public AudioClip[] Attack;

	[HideInInspector]
	public SpriteRenderer ThisSprite;

	[HideInInspector]
	public Animator EnemyAnimator;

	[HideInInspector]
	public AudioSource EnemyAudio;

	[HideInInspector]
	public Camera referenceCamera;

	[HideInInspector]
	public InformerScript GetInfo;

	private void Start()
	{
		ThisSprite = GetComponent<SpriteRenderer>();
		ThisSprite.color = StandartColor;
	}

	private IEnumerator ChangeColor()
	{
		yield return new WaitForSeconds(0.3f);
		ThisSprite.color = StandartColor;
	}

	public void HitColorChanger()
	{
		ThisSprite.color = HitColor;
		StartCoroutine(ChangeColor());
	}

	public virtual void Hitting(int Value)
	{
	}

	private void Update()
	{
		EnemyAudio.volume = Settings.Sound;
	}
}
