using UnityEngine;
using UnityEngine.UI;

public class PauseSliders : MonoBehaviour
{
	public enum SETTING
	{
		MouseSensitivity,
		SoundsVolume
	}

	[HideInInspector]
	public Slider Self;

	public SETTING _setting;

	private void Start()
	{
		Self = GetComponent<Slider>();
		switch (_setting)
		{
		case SETTING.MouseSensitivity:
			Self.value = Settings.Mouse * 0.005f;
			break;
		case SETTING.SoundsVolume:
			Self.value = Settings.Sound;
			break;
		}
	}

	public void ChangeMouse(float _val)
	{
		Settings.Mouse = _val * 200f;
	}

	public void ChangeSound(float _val)
	{
		Settings.Sound = _val;
	}

	private void Update()
	{
	}
}
