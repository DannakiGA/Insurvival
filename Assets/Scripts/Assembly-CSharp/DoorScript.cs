using UnityEngine;

public class DoorScript : MonoBehaviour
{
	[HideInInspector]
	public Animator _animator;

	[HideInInspector]
	public AudioSource _audio;

	public AudioClip OpenDoorSound;

	private void Start()
	{
		_animator = GetComponent<Animator>();
		_audio = GetComponent<AudioSource>();
	}

	public void OpenDoor()
	{
		_animator.SetTrigger("Open");
		_audio.PlayOneShot(OpenDoorSound);
	}

	private void Update()
	{
		_audio.volume = Settings.Sound;
	}
}
