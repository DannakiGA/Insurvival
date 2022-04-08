using UnityEngine;

public class Billboard : MonoBehaviour
{
	private Camera referenceCamera;

	private void Start()
	{
		if (!referenceCamera)
		{
			referenceCamera = Camera.main;
		}
	}

	private void LateUpdate()
	{
		base.transform.LookAt(base.transform.position + referenceCamera.transform.rotation * -Vector3.forward, referenceCamera.transform.rotation * Vector3.up);
	}
}
