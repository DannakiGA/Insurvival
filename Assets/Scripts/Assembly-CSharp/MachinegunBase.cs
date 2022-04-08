using System.Collections;
using UnityEngine;

public class MachinegunBase : ShootableWeaponBase
{
	//private IEnumerator Shoot()
	//{
	//	int num = 1024;
	//	num = ~num;
	//	RaycastHit hitInfo;
	//	if (Physics.Raycast(ReferenceCamera.transform.position, ReferenceCamera.transform.forward, out hitInfo, Range, num) && hitInfo.collider != null)
	//	{
	//		if (hitInfo.collider.tag == "Robot")
	//		{
	//			Object.Instantiate(RobotParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
	//			hitInfo.collider.GetComponent<EnemyBase>().Hitting(4 + Parameters.AddDamage);
	//		}
	//		if (hitInfo.collider.tag == "Enemy")
	//		{
	//			Object.Instantiate(BloodParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
	//			hitInfo.collider.GetComponent<EnemyBase>().Hitting(4 + Parameters.AddDamage);
	//		}
	//	}
	//	WeaponAnimator.SetBool("isShoot", true);
	//	Parameters.ammo_chaingun--;
	//	WeaponAudio.PlayOneShot(ShootSound[Random.Range(0, ShootSound.Length)]);
	//	yield return new WaitForSeconds(TimeBetweenShots);
	//	isCanShoot = true;
	//}

	//private void Update()
	//{
	//	WeaponAudio.volume = Settings.Sound;
	//	if (Input.GetMouseButton(0) && Parameters.ammo_chaingun > 0 && isCanShoot)
	//	{
	//		isCanShoot = false;
	//		StartCoroutine(Shoot());
	//	}
	//	if (Input.GetMouseButtonUp(0))
	//	{
	//		WeaponAnimator.SetBool("isShoot", false);
	//	}
	//	if (Parameters.ammo_chaingun < 1)
	//	{
	//		WeaponAnimator.SetBool("isShoot", false);
	//	}
	//}
}
