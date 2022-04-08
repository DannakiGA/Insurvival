using UnityEngine;

public class Parameters : MonoBehaviour
{
	public static int Radiation = 0;

	public static int ammo_shotgun = 8;

	public static int ammo_chaingun = 12;

	public static int ammo_minigun = 120;

	public static bool weapon_axe = false;

	public static bool weapon_beretta = false;

	public static bool weapon_double = false;

	public static bool weapon_sig = false;

	public static bool weapon_minigun = false;

	public static int CurrentWeapon = -1;

	public static string textInfo = " ";

	public static int Medkit = 0;

	public static int StopRad = 0;

	public static int Bandage = 0;

	public static int Level = 1;

	public static int AddDamage = 0;

	public static int AddHealth = 0;

	public static int AddSpeed = 0;

	public static int PointExpir = 0;

	public static float exp = 12f;

	public static float max_exp = 120f;

	public static int Max = 99;

	public static int Health = Max + AddHealth;

	public static bool Pause = false;
}
