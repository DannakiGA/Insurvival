using UnityEngine;

public class Bullets : MonoBehaviour
{
	public float Speed;

	private Vector3 CameraPosition;

	private Camera referenceCamera;

	private void Start()
	{
		if (!referenceCamera)
		{
			referenceCamera = Camera.main;
		}
		CameraPosition = new Vector3(referenceCamera.transform.position.x - base.transform.position.x, base.transform.position.y - referenceCamera.transform.position.y, referenceCamera.transform.position.z - base.transform.position.z);
	}

	private void Update()
	{
		base.transform.Translate(CameraPosition * Speed * Time.deltaTime);
		int num = 2048;
		num = ~num;
		RaycastHit hitInfo;
		if (Physics.Raycast(base.transform.position, referenceCamera.transform.position - base.transform.position, out hitInfo, 1f, num) && hitInfo.collider != null && hitInfo.collider.tag == "Level")
		{
			Object.Destroy(base.gameObject);
		}
		Object.Destroy(base.gameObject, 4f);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			GruntSource.Get().SetHealthValue = -22;
			Object.Destroy(base.gameObject);
		}
	}
}
