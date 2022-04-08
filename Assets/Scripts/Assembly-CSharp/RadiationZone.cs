using System.Collections;
using UnityEngine;

public class RadiationZone : MonoBehaviour
{
	private bool can_hit = true;

	private IEnumerator RadiationFill()
	{
		can_hit = false;
		Parameters.Radiation++;
		yield return new WaitForSeconds(0.5f);
		can_hit = true;
	}

	private void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player" && can_hit)
		{
			StartCoroutine(RadiationFill());
		}
	}
}
