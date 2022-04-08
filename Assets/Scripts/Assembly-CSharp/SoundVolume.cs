using UnityEngine;

public class SoundVolume : MonoBehaviour
{
	[HideInInspector]
	public AudioSource _self;

	private void Start()
	{
		_self = GetComponent<AudioSource>();
		_self.volume = Settings.Sound;
	}

	private void Update()
	{
		_self.volume = Settings.Sound;
	}
}
