using UnityEngine;

public class MessageActivator : MonoBehaviour
{
	public GameObject Message;

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Message.SetActive(true);
			Object.Destroy(base.gameObject);
		}
	}
}
