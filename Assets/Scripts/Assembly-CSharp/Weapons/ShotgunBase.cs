using System.Collections;
using UnityEngine;

public class ShotgunBase : ShootableWeaponBase
{
    private void Update()
    {
        if (Input.GetMouseButton(0) && Parameters.ammo_chaingun > 0 && isCanShoot)
        {
            isCanShoot = false;
            StartCoroutine(Shoot("Shoot", 8));
        }
    }
}
