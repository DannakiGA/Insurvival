using UnityEngine;

public class Hand : MonoBehaviour
{
	[HideInInspector]
	public Camera referenceCamera;

	[HideInInspector]
	public InformerScript Notification;

	private void Start()
	{
		if (!referenceCamera)
		{
			referenceCamera = Camera.main;
		}
		InformerScript informerScript = (InformerScript)Object.FindObjectOfType(typeof(InformerScript));
		Notification = informerScript.GetComponent<InformerScript>();
	}

	public void Check()
	{
		int num = 1024;
		num = ~num;
		RaycastHit hitInfo;
		if (Physics.Raycast(referenceCamera.transform.position, referenceCamera.transform.forward, out hitInfo, 2f, num) && hitInfo.collider != null)
		{
			if (hitInfo.collider.tag == "Computer")
			{
				hitInfo.collider.GetComponent<ComputerScript>().Hacking();
			}
			if (hitInfo.collider.tag == "NextLevel")
			{
				hitInfo.collider.GetComponent<LevelChanger>().MoveToNextLevel();
			}
		}
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.F))
		{
			Check();
		}
	}

	private void LateUpdate()
	{
		if (Input.GetKeyUp(KeyCode.F1) && Parameters.Bandage > 0)
		{
			Parameters.Bandage--;
			Parameters.Health += 10;
			Notification.GetUseItem();
		}
		if (Input.GetKeyUp(KeyCode.F2) && Parameters.Medkit > 0)
		{
			Parameters.Medkit--;
			Parameters.Health += 50;
			Notification.GetUseItem();
		}
		if (Input.GetKeyUp(KeyCode.F3) && Parameters.StopRad > 0)
		{
			Parameters.StopRad--;
			Parameters.Radiation = 0;
			Notification.GetUseItem();
		}
	}
}
