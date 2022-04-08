using UnityEngine;

public class BarrelExplode : MonoBehaviour
{
	[HideInInspector]
	public InformerScript GetInfo;

	private void Start()
	{
		InformerScript informerScript = (InformerScript)Object.FindObjectOfType(typeof(InformerScript));
		GetInfo = informerScript.GetComponent<InformerScript>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			GetInfo.GetHit(25);
		}
		if (other.tag == "Robot")
		{
			other.GetComponent<EnemyBase>().Hitting(250);
		}
		if (other.tag == "Enemy")
		{
			other.GetComponent<EnemyBase>().Hitting(250);
		}
		if (other.tag == "Crate")
		{
			other.GetComponent<CrateScript>().Hitting(25);
		}
	}
}
