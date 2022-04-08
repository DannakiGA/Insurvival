using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
	[Serializable]
	public class PlayerParameters
	{
		public int _Radiation;

		public int _ammo_shotgun;

		public int _ammo_chaingun;

		public int _ammo_minigun;

		public bool _weapon_axe;

		public bool _weapon_beretta;

		public bool _weapon_double;

		public bool _weapon_sig;

		public bool _weapon_minigun;

		public int _CurrentWeapon;

		public int _Medkit;

		public int _StopRad;

		public int _Bandage;

		public int _Level;

		public int _AddDamage;

		public int _AddHealth;

		public int _AddSpeed;

		public int _PointExpir;

		public float _exp;

		public float _max_exp;

		public int _Health;

		public int _scene;
	}

	public int SceneNumber;

	public void Save()
	{
		PlayerParameters playerParameters = new PlayerParameters();
		playerParameters._Radiation = Parameters.Radiation;
		playerParameters._ammo_shotgun = Parameters.ammo_shotgun;
		playerParameters._ammo_chaingun = Parameters.ammo_chaingun;
		playerParameters._ammo_minigun = Parameters.ammo_minigun;
		playerParameters._weapon_axe = Parameters.weapon_axe;
		playerParameters._weapon_beretta = Parameters.weapon_beretta;
		playerParameters._weapon_double = Parameters.weapon_double;
		playerParameters._weapon_sig = Parameters.weapon_sig;
		playerParameters._weapon_minigun = Parameters.weapon_minigun;
		playerParameters._CurrentWeapon = Parameters.CurrentWeapon;
		playerParameters._Medkit = Parameters.Medkit;
		playerParameters._StopRad = Parameters.StopRad;
		playerParameters._Bandage = Parameters.Bandage;
		playerParameters._Level = Parameters.Level;
		playerParameters._AddDamage = Parameters.AddDamage;
		playerParameters._AddHealth = Parameters.AddHealth;
		playerParameters._AddSpeed = Parameters.AddSpeed;
		playerParameters._PointExpir = Parameters.PointExpir;
		playerParameters._exp = Parameters.exp;
		playerParameters._max_exp = Parameters.max_exp;
		playerParameters._Health = Parameters.Health;
		playerParameters._scene = SceneNumber;
		if (!Directory.Exists(Application.dataPath + "/Saves"))
		{
			Directory.CreateDirectory(Application.dataPath + "/Saves");
		}
		FileStream fileStream = new FileStream(Application.dataPath + "/Saves/heartbeat.save", FileMode.Create);
		new BinaryFormatter().Serialize(fileStream, playerParameters);
		fileStream.Close();
	}

	public void Load()
	{
		if (File.Exists(Application.dataPath + "/Saves/heartbeat.save"))
		{
			FileStream fileStream = new FileStream(Application.dataPath + "/Saves/heartbeat.save", FileMode.Open);
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			try
			{
				PlayerParameters playerParameters = (PlayerParameters)binaryFormatter.Deserialize(fileStream);
				Parameters.Radiation = playerParameters._Radiation;
				Parameters.ammo_shotgun = playerParameters._ammo_shotgun;
				Parameters.ammo_chaingun = playerParameters._ammo_chaingun;
				Parameters.ammo_minigun = playerParameters._ammo_minigun;
				Parameters.weapon_axe = playerParameters._weapon_axe;
				Parameters.weapon_beretta = playerParameters._weapon_beretta;
				Parameters.weapon_double = playerParameters._weapon_double;
				Parameters.weapon_sig = playerParameters._weapon_sig;
				Parameters.weapon_minigun = playerParameters._weapon_minigun;
				Parameters.CurrentWeapon = playerParameters._CurrentWeapon;
				Parameters.Medkit = playerParameters._Medkit;
				Parameters.StopRad = playerParameters._StopRad;
				Parameters.Bandage = playerParameters._Bandage;
				Parameters.Level = playerParameters._Level;
				Parameters.AddDamage = playerParameters._AddDamage;
				Parameters.AddHealth = playerParameters._AddHealth;
				Parameters.AddSpeed = playerParameters._AddSpeed;
				Parameters.PointExpir = playerParameters._PointExpir;
				Parameters.exp = playerParameters._exp;
				Parameters.max_exp = playerParameters._max_exp;
				Parameters.Health = playerParameters._Health;
				SceneNumber = playerParameters._scene;
				return;
			}
			catch (Exception ex)
			{
				Debug.Log(ex.Message);
				return;
			}
			finally
			{
				fileStream.Close();
				SceneManager.LoadScene(SceneNumber);
				Time.timeScale = 1f;
			}
		}
		Application.Quit();
	}

	public void ReturnToMain()
	{
		SceneManager.LoadScene(0);
	}
}
