using UnityEngine;

public class ComputerScript : MonoBehaviour
{
	public GameObject Door;

	public int Chance;

	[HideInInspector]
	public int Access;

	[HideInInspector]
	public GID TextAlert;

	[HideInInspector]
	public InformerScript Notification;

	private void Start()
	{
		GID gID = (GID)Object.FindObjectOfType(typeof(GID));
		TextAlert = gID.GetComponent<GID>();
		InformerScript informerScript = (InformerScript)Object.FindObjectOfType(typeof(InformerScript));
		Notification = informerScript.GetComponent<InformerScript>();
	}

	public void Hacking()
	{
		Access = Random.Range(0, Chance);
		if (Chance == 999)
		{
			Access = 1;
		}
		if (Access == 1)
		{
			Succes();
		}
		if (Access != 1)
		{
			switch (Settings.Language)
			{
			case 0:
				TextAlert.SendTitle("Attempt to haking a terminal failed");
				break;
			case 1:
				TextAlert.SendTitle("Попытка взлома терминала провалилась");
				break;
			}
		}
	}

	public void Succes()
	{
		DoorScript component = Door.GetComponent<DoorScript>();
		Notification.GetUseItem();
		switch (Settings.Language)
		{
		case 0:
			TextAlert.SendTitle("You have successfully hacked a terminal");
			break;
		case 1:
			TextAlert.SendTitle("Вы успешно взломали терминал");
			break;
		}
		//Parameters.exp += 22f;
		component.OpenDoor();
		Object.Destroy(base.gameObject);
	}
}
