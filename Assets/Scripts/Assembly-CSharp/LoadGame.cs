using System;
using UnityEngine;

public class LoadGame : MonoBehaviour
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
}
