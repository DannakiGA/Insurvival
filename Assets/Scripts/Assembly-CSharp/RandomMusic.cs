using UnityEngine;

public class RandomMusic : MonoBehaviour
{
	[HideInInspector]
	public AudioSource Source;

	public AudioClip[] Music;

	private void Start()
	{
		Source = GetComponent<AudioSource>();
		Source.clip = Music[Random.Range(0, Music.Length)];
		Source.Play();
	}

	public void MusicState(bool State)
	{
		if (!State)
		{
			Source.Pause();
		}
		if (State)
		{
			Source.UnPause();
		}
	}

	private void Update()
	{
		Source.volume = Settings.Sound;
	}
}
