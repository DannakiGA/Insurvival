using System.Collections;
using UnityEngine;

public class Changer : MonoBehaviour
{
	public GameObject[] Weapons;

	private void Start()
	{
		StartCoroutine(ChangeWeapon());
	}

	private IEnumerator ChangeWeapon()
	{
		switch (Parameters.CurrentWeapon)
		{
		case 0:
			Weapons[0].SetActive(true);
			Weapons[1].SetActive(false);
			Weapons[2].SetActive(false);
			Weapons[3].SetActive(false);
			Weapons[4].SetActive(false);
			break;
		case 1:
			Weapons[0].SetActive(false);
			Weapons[1].SetActive(true);
			Weapons[2].SetActive(false);
			Weapons[3].SetActive(false);
			Weapons[4].SetActive(false);
			break;
		case 2:
			Weapons[0].SetActive(false);
			Weapons[1].SetActive(false);
			Weapons[2].SetActive(true);
			Weapons[3].SetActive(false);
			Weapons[4].SetActive(false);
			break;
		case 3:
			Weapons[0].SetActive(false);
			Weapons[1].SetActive(false);
			Weapons[2].SetActive(false);
			Weapons[3].SetActive(true);
			Weapons[4].SetActive(false);
			break;
		case 4:
			Weapons[0].SetActive(false);
			Weapons[1].SetActive(false);
			Weapons[2].SetActive(false);
			Weapons[3].SetActive(false);
			Weapons[4].SetActive(true);
			break;
		}
		yield return new WaitForSeconds(0.1f);
	}

	public void UpdateWeapon()
	{
		StartCoroutine(ChangeWeapon());
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.Alpha1) && Parameters.weapon_axe)
		{
			Parameters.CurrentWeapon = 0;
			StartCoroutine(ChangeWeapon());
		}
		if (Input.GetKey(KeyCode.Alpha2) && Parameters.weapon_beretta)
		{
			Parameters.CurrentWeapon = 1;
			StartCoroutine(ChangeWeapon());
		}
		if (Input.GetKey(KeyCode.Alpha3) && Parameters.weapon_double)
		{
			Parameters.CurrentWeapon = 2;
			StartCoroutine(ChangeWeapon());
		}
		if (Input.GetKey(KeyCode.Alpha4) && Parameters.weapon_sig)
		{
			Parameters.CurrentWeapon = 3;
			StartCoroutine(ChangeWeapon());
		}
		if (Input.GetKey(KeyCode.Alpha5) && Parameters.weapon_minigun)
		{
			Parameters.CurrentWeapon = 4;
			StartCoroutine(ChangeWeapon());
		}
	}
}
