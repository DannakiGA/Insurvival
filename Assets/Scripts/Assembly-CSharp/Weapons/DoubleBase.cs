using System.Collections;
using UnityEngine;

public class DoubleBase : ShootableWeaponBase
{
	//private IEnumerator Shoot()
	//{
	//	int num = 1024;
	//	num = ~num;
	//	for (int i = 0; i < 6; i++)
	//	{
	//		RaycastHit hitInfo;
	//		if (Physics.Raycast(ReferenceCamera.transform.position, ReferenceCamera.transform.forward + new Vector3(Random.Range(-0.2f, 0.2f), 0f, Random.Range(-0.2f, 0.2f)), out hitInfo, Range, num) && hitInfo.collider != null)
	//		{
	//			if (hitInfo.collider.tag == "Robot")
	//			{
	//				Object.Instantiate(RobotParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
	//				hitInfo.collider.GetComponent<EnemyBase>().Hitting(5 + Parameters.AddDamage);
	//			}
	//			if (hitInfo.collider.tag == "Enemy")
	//			{
	//				Object.Instantiate(BloodParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
	//				hitInfo.collider.GetComponent<EnemyBase>().Hitting(5 + Parameters.AddDamage);
	//			}
	//		}
	//	}
	//	WeaponAnimator.SetTrigger("isShoot");
	//	Parameters.ammo_shotgun -= 2;
	//	WeaponAudio.PlayOneShot(ShootSound[Random.Range(0, ShootSound.Length)]);
	//	yield return new WaitForSeconds(TimeBetweenShots);
	//	isCanShoot = true;
	//}

	//private void Update()
	//{
	//	if (Input.GetMouseButton(0) && Parameters.ammo_shotgun > 1 && isCanShoot)
	//	{
	//		isCanShoot = false;
	//		StartCoroutine(Shoot());
	//	}
	//	WeaponAudio.volume = Settings.Sound;
	//}
}
