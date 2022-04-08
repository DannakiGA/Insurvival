using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
	public Text BandageText;

	public Text StopRadText;

	public Text MedkitText;

	[HideInInspector]
	public InformerScript Notification;

	private void Start()
	{
		InformerScript informerScript = (InformerScript)Object.FindObjectOfType(typeof(InformerScript));
		Notification = informerScript.GetComponent<InformerScript>();
		switch (Settings.Language)
		{
		case 0:
			MedkitText.text = "Medkits " + Parameters.Medkit;
			StopRadText.text = "StopRads " + Parameters.StopRad;
			BandageText.text = "Bandages " + Parameters.Bandage;
			break;
		case 1:
			MedkitText.text = "Аптечки " + Parameters.Medkit;
			StopRadText.text = "СтопРад " + Parameters.StopRad;
			BandageText.text = "Бинты " + Parameters.Bandage;
			break;
		}
	}

	private void OnEnable()
	{
		BagUpdate();
	}

	public void BagUpdate()
	{
		switch (Settings.Language)
		{
		case 0:
			MedkitText.text = "Medkits " + Parameters.Medkit;
			StopRadText.text = "StopRads " + Parameters.StopRad;
			BandageText.text = "Bandages " + Parameters.Bandage;
			break;
		case 1:
			MedkitText.text = "Аптечки " + Parameters.Medkit;
			StopRadText.text = "СтопРад " + Parameters.StopRad;
			BandageText.text = "Бинты " + Parameters.Bandage;
			break;
		}
	}

	public void BandageUse()
	{
		if (Parameters.Bandage > 0)
		{
			Parameters.Bandage--;
			Parameters.Health += 10;
			Notification.GetUseItem();
			BagUpdate();
		}
	}

	public void MedkitUse()
	{
		if (Parameters.Medkit > 0)
		{
			Parameters.Medkit--;
			Parameters.Health += 50;
			Notification.GetUseItem();
			BagUpdate();
		}
	}

	public void StopRadUse()
	{
		if (Parameters.StopRad > 0)
		{
			Parameters.StopRad--;
			Parameters.Radiation = 0;
			Notification.GetUseItem();
			BagUpdate();
		}
	}
}
