using UnityEngine;

public class CrateScript : MonoBehaviour
{
	public GameObject[] Items;

	public int Health;

	public GameObject WoodParticle;

	public void Hitting(int Value)
	{
		Health -= Value;
		if (Health < 1)
		{
			Object.Instantiate(WoodParticle, base.transform.position, Quaternion.Euler(base.transform.rotation.eulerAngles.x - 90f, base.transform.rotation.eulerAngles.y, base.transform.rotation.eulerAngles.z));
			Object.Instantiate(Items[Random.Range(0, Items.Length)], base.transform.position, Quaternion.identity);
			GruntSource.Get().SetExperience = 7;
			Object.Destroy(base.gameObject);
		}
	}
}
