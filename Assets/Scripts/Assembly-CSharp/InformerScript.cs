using UnityEngine;
using UnityEngine.UI;

public class InformerScript : MonoBehaviour
{
	public Color ItemTake;

	public Color Hit;

	public Color UseItem;

	[HideInInspector]
	public Color ScreenColor;

	[HideInInspector]
	public Image Screen;

	[HideInInspector]
	public AudioSource Source;

	public AudioClip[] Damage;

	public AudioClip Item;

	public AudioClip Use;

	private void Start()
	{
		Screen = GetComponent<Image>();
		ScreenColor = Screen.color;
		Source = GetComponent<AudioSource>();
	}

	public void GetHit(int Value)
	{
		ScreenColor = Hit;
		Source.PlayOneShot(Damage[Random.Range(0, Damage.Length)]);
		Parameters.Health -= Value;
	}

	public void GetItem()
	{
		ScreenColor = ItemTake;
		Source.PlayOneShot(Item);
	}

	public void GetUseItem()
	{
		ScreenColor = UseItem;
		Source.PlayOneShot(Use);
	}

	private void Update()
	{
		if (ScreenColor.a > 0f)
		{
			ScreenColor.a -= 0.7f * Time.deltaTime;
			Screen.color = ScreenColor;
		}
		Source.volume = Settings.Sound;
	}
}
