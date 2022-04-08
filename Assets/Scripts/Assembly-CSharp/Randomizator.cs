using System.Collections;
using UnityEngine;

public class Randomizator : MonoBehaviour
{
	public GameObject[] Spawn;

	private void Start()
	{
		StartCoroutine(Create());
	}

	private IEnumerator Create()
	{
		Object.Instantiate(Spawn[Random.Range(0, Spawn.Length)], base.transform.position, base.transform.rotation);
		Object.Destroy(base.gameObject);
		yield return new WaitForSeconds(0.01f);
	}
}
