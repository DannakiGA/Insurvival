using UnityEngine;

public class DoorScript : MonoBehaviour
{
	Animator animator;
	public AudioClip OpenDoorSound;

	private void Start()
	{
		animator = GetComponent<Animator>();
	}

	public void OpenDoor()
	{
		animator.SetTrigger("Open");
	}
}
