using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject Buttons;

	public GameObject Setting;

	public GameObject Readme;

	private void Start()
	{
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void NewGame()
	{
		SceneManager.LoadScene(2);
		Time.timeScale = 1f;
		Parameters.Radiation = 0;
		Parameters.ammo_shotgun = 8;
		Parameters.ammo_chaingun = 12;
		Parameters.ammo_minigun = 120;
		Parameters.weapon_axe = false;
		Parameters.weapon_beretta = false;
		Parameters.weapon_double = false;
		Parameters.weapon_sig = false;
		Parameters.weapon_minigun = false;
		Parameters.CurrentWeapon = -1;
		Parameters.textInfo = " ";
		Parameters.Medkit = 0;
		Parameters.StopRad = 0;
		Parameters.Bandage = 0;
		Parameters.Level = 1;
		Parameters.AddDamage = 0;
		Parameters.AddHealth = 0;
		Parameters.AddSpeed = 0;
		Parameters.PointExpir = 0;
		Parameters.exp = 12f;
		Parameters.max_exp = 120f;
		Parameters.Max = 99;
		Parameters.Health = Parameters.Max + Parameters.AddHealth;
	}

	public void SettingGame()
	{
		Buttons.SetActive(false);
		Setting.SetActive(true);
	}

	public void ReadmeGame()
	{
		SceneManager.LoadScene(1);
		Time.timeScale = 1f;
		Parameters.Radiation = 0;
		Parameters.ammo_shotgun = 8;
		Parameters.ammo_chaingun = 12;
		Parameters.ammo_minigun = 120;
		Parameters.weapon_axe = false;
		Parameters.weapon_beretta = false;
		Parameters.weapon_double = false;
		Parameters.weapon_sig = false;
		Parameters.weapon_minigun = false;
		Parameters.CurrentWeapon = -1;
		Parameters.textInfo = " ";
		Parameters.Medkit = 0;
		Parameters.StopRad = 0;
		Parameters.Bandage = 0;
		Parameters.Level = 1;
		Parameters.AddDamage = 0;
		Parameters.AddHealth = 0;
		Parameters.AddSpeed = 0;
		Parameters.PointExpir = 0;
		Parameters.exp = 12f;
		Parameters.max_exp = 120f;
		Parameters.Max = 99;
		Parameters.Health = Parameters.Max + Parameters.AddHealth;
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Setting.SetActive(false);
			Buttons.SetActive(true);
		}
	}
}
