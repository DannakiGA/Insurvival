using System.Collections;
using UnityEngine;

public class MinigunBase : ShootableWeaponBase
{
	//private IEnumerator Shoot()
	//{
	//	int num = 1024;
	//	num = ~num;
	//	RaycastHit hitInfo;
	//	if (Physics.Raycast(ReferenceCamera.transform.position, ReferenceCamera.transform.forward + new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f)), out hitInfo, Range, num) && hitInfo.collider != null)
	//	{
	//		if (hitInfo.collider.tag == "Robot")
	//		{
	//			Object.Instantiate(RobotParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
	//			hitInfo.collider.GetComponent<EnemyBase>().Hitting(8 + Parameters.AddDamage);
	//		}
	//		if (hitInfo.collider.tag == "Enemy")
	//		{
	//			Object.Instantiate(BloodParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
	//			hitInfo.collider.GetComponent<EnemyBase>().Hitting(8 + Parameters.AddDamage);
	//		}
	//	}
	//	WeaponAnimator.SetBool("isShoot", true);
	//	Parameters.ammo_minigun--;
	//	WeaponAudio.PlayOneShot(ShootSound[Random.Range(0, ShootSound.Length)]);
	//	yield return new WaitForSeconds(TimeBetweenShots);
	//	isCanShoot = true;
	//}

	//private void Update()
	//{
	//	WeaponAudio.volume = Settings.Sound;
	//	if (Input.GetMouseButton(0) && Parameters.ammo_minigun > 0 && isCanShoot)
	//	{
	//		isCanShoot = false;
	//		StartCoroutine(Shoot());
	//	}
	//	if (Input.GetMouseButtonUp(0))
	//	{
	//		WeaponAnimator.SetBool("isShoot", false);
	//	}
	//	if (Parameters.ammo_minigun < 1)
	//	{
	//		WeaponAnimator.SetBool("isShoot", false);
	//	}
	//}
}
