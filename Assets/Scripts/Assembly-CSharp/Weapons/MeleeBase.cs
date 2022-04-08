using System.Collections;
using UnityEngine;

public class MeleeBase : ShootableWeaponBase
{
	private void Update()
	{
		if (Input.GetMouseButton(0) && isCanShoot)
		{
			isCanShoot = false;
			StartCoroutine(Shoot("Bite", 4));
		}
	}
}
