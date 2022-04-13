using System.Collections;
using UnityEngine;

public class Changer : MonoBehaviour
{
	public GameObject[] WeaponsModel;

	private IEnumerator ChangeWeapon(Weapons weapon)
	{
		switch (weapon)
		{
			case Weapons.Pipe:
				WeaponsModel[0].SetActive(true);
				WeaponsModel[1].SetActive(false);
				WeaponsModel[2].SetActive(false);
				WeaponsModel[3].SetActive(false);
				WeaponsModel[4].SetActive(false);
				break;
			case Weapons.Gun12mm:
				WeaponsModel[0].SetActive(false);
				WeaponsModel[1].SetActive(true);
				WeaponsModel[2].SetActive(false);
				WeaponsModel[3].SetActive(false);
				WeaponsModel[4].SetActive(false);
				break;
			case Weapons.Double:
				WeaponsModel[0].SetActive(false);
				WeaponsModel[1].SetActive(false);
				WeaponsModel[2].SetActive(true);
				WeaponsModel[3].SetActive(false);
				WeaponsModel[4].SetActive(false);
				break;
			case Weapons.Sig:
				WeaponsModel[0].SetActive(false);
				WeaponsModel[1].SetActive(false);
				WeaponsModel[2].SetActive(false);
				WeaponsModel[3].SetActive(true);
				WeaponsModel[4].SetActive(false);
				break;
			case Weapons.Minigun:
				WeaponsModel[0].SetActive(false);
				WeaponsModel[1].SetActive(false);
				WeaponsModel[2].SetActive(false);
				WeaponsModel[3].SetActive(false);
				WeaponsModel[4].SetActive(true);
				break;
		}
		yield return new WaitForSeconds(0.1f);
	}

	public void UpdateWeapon(Weapons weapon)
	{
		StartCoroutine(ChangeWeapon(weapon));
	}

	private void Update()
	{
		UpdateWeapon(GruntSource.Get().CurrentWeaponInHands);

		if (Input.GetKey(KeyCode.Alpha1) && GruntSource.Get().CurrentWeaponInHands == Weapons.Gun12mm)
		{
			StartCoroutine(ChangeWeapon(GruntSource.Get().CurrentWeaponInHands));
		}
		if (Input.GetKey(KeyCode.Alpha2) && GruntSource.Get().CurrentWeaponInHands == Weapons.Gun12mm)
		{
			StartCoroutine(ChangeWeapon(GruntSource.Get().CurrentWeaponInHands));
		}
		if (Input.GetKey(KeyCode.Alpha3) && Parameters.weapon_double)
		{
			StartCoroutine(ChangeWeapon(GruntSource.Get().CurrentWeaponInHands));
		}
		if (Input.GetKey(KeyCode.Alpha4) && Parameters.weapon_sig)
		{
			StartCoroutine(ChangeWeapon(GruntSource.Get().CurrentWeaponInHands));
		}
		if (Input.GetKey(KeyCode.Alpha5) && Parameters.weapon_minigun)
		{
			StartCoroutine(ChangeWeapon(GruntSource.Get().CurrentWeaponInHands));
		}
	}
}
