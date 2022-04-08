using UnityEngine;

public class RandomDeathSounds : MonoBehaviour
{
	private AudioSource Private;

	public AudioClip[] Die;

	private bool CanPlay = true;

	private void Start()
	{
		Private = GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (CanPlay)
		{
			Private.PlayOneShot(Die[Random.Range(0, Die.Length)]);
			CanPlay = !CanPlay;
		}
		Private.volume = Settings.Sound;
	}
}
