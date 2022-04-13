using UnityEngine;

public class BarrelExplode : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			GruntSource.Get().SetHealthValue = -25;
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
