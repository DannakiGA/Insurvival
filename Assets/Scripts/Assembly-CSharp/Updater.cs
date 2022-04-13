using System;
using System.Collections;
using UnityEngine;
using Object = UnityEngine.Object;

public class Updater : MonoBehaviour
{
	bool can_hit = true;
	public InformerScript Notification;
	GID TextAlert;

	private void Start()
	{
		GruntSource.Get().StartPlayer(transform.position, transform.rotation);
		GID gID = (GID)Object.FindObjectOfType(typeof(GID));
		TextAlert = gID.GetComponent<GID>();
	}



	private IEnumerator RadiationHit()
	{
		can_hit = false;
		var radiationHitValue = Mathf.RoundToInt((float)GruntSource.Get().GetRadiationLevel * 0.3f + 1f);
		GruntSource.Get().SetRadiationLevel = radiationHitValue;
		GruntSource.Get().SetHealthValue = -radiationHitValue;

		Notification.GetHit();
		//switch (Settings.Language)
		//{
		//case 0:
		//	TextAlert.SendTitle("You got radiation damage " + (int)((float)Parameters.Radiation * 0.3f + 1f));
		//	break;
		//case 1:
		//	TextAlert.SendTitle("Вы получили урон от радиации " + (int)((float)Parameters.Radiation * 0.3f + 1f));
		//	break;
		//}
		yield return new WaitForSeconds(1.5f);
		can_hit = true;
	}

	private void Update()
	{
		if (GruntSource.Get().GetRadiationLevel > 0 && can_hit)
		{
			StartCoroutine(RadiationHit());
		}
	}
}
