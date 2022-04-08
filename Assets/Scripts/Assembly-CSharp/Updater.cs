using System.Collections;
using UnityEngine;

public class Updater : MonoBehaviour
{
	private bool can_hit = true;

	[HideInInspector]
	public InformerScript Notification;

	[HideInInspector]
	public GID TextAlert;

	private void Start()
	{
		InformerScript informerScript = (InformerScript)Object.FindObjectOfType(typeof(InformerScript));
		GID gID = (GID)Object.FindObjectOfType(typeof(GID));
		Notification = informerScript.GetComponent<InformerScript>();
		TextAlert = gID.GetComponent<GID>();
	}

	private IEnumerator RadiationHit()
	{
		can_hit = false;
		Notification.GetHit((int)((float)Parameters.Radiation * 0.3f + 1f));
		switch (Settings.Language)
		{
		case 0:
			TextAlert.SendTitle("You got radiation damage " + (int)((float)Parameters.Radiation * 0.3f + 1f));
			break;
		case 1:
			TextAlert.SendTitle("Вы получили урон от радиации " + (int)((float)Parameters.Radiation * 0.3f + 1f));
			break;
		}
		yield return new WaitForSeconds(1.5f);
		can_hit = true;
	}

	private void Update()
	{
		if (Parameters.Health > Parameters.Max + Parameters.AddHealth)
		{
			Parameters.Health = Parameters.Max + Parameters.AddHealth;
		}
		if (Parameters.Radiation > 0 && can_hit)
		{
			StartCoroutine(RadiationHit());
		}
		if (Parameters.Radiation >= 100)
		{
			Parameters.Radiation = 100;
		}
	}
}
