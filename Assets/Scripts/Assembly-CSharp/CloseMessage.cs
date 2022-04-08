using UnityEngine;

public class CloseMessage : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKey(KeyCode.Return))
		{
			base.gameObject.SetActive(false);
		}
	}
}
