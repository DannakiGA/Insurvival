using UnityEngine;
using UnityEngine.UI;

public class TextInfo : MonoBehaviour
{
	public enum ShowGUI
	{
		HealthInfo,
		AmmoInfo,
		RadiationInfo,
		BandageCount,
		MedkitCount,
		AntiradinCount
	}

	[HideInInspector]
	public Text Self;

	public ShowGUI Texts;

	private void Start()
	{
		Self = GetComponent<Text>();
	}

	private void Update()
	{
		switch (Texts)
		{
		case ShowGUI.HealthInfo:
			Self.text = GruntSource.Get().GetHealthValue.ToString();
			break;
		case ShowGUI.AmmoInfo:
			switch (Parameters.CurrentWeapon)
			{
			case 0:
				Self.text = " ";
				break;
			case 1:
				Self.text = string.Concat(Parameters.ammo_chaingun);
				break;
			case 2:
				Self.text = string.Concat(Parameters.ammo_shotgun);
				break;
			case 3:
				Self.text = string.Concat(Parameters.ammo_chaingun);
				break;
			case 4:
				Self.text = string.Concat(Parameters.ammo_minigun);
				break;
			}
			break;
		case ShowGUI.RadiationInfo:
			Self.text = GruntSource.Get().GetRadiationLevel.ToString();
			break;
		case ShowGUI.BandageCount:
				Self.text = string.Concat(Parameters.Bandage);
				break;
		case ShowGUI.MedkitCount:
				Self.text = string.Concat(Parameters.Medkit);
				break;
		case ShowGUI.AntiradinCount:
				Self.text = string.Concat(Parameters.StopRad);
				break;
		}
	}
}
