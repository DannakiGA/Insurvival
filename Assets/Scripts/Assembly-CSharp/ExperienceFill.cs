using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceFill : MonoBehaviour
{
	[HideInInspector]
	public Slider Self;

	[HideInInspector]
	public MenuSwaper Swaper;

	[HideInInspector]
	public Grunt Hero;

	private bool _trig = true;

	private void Start()
	{
		Self = GetComponent<Slider>();
		MenuSwaper menuSwaper = (MenuSwaper)Object.FindObjectOfType(typeof(MenuSwaper));
		Swaper = menuSwaper.GetComponent<MenuSwaper>();
		Grunt grunt = (Grunt)Object.FindObjectOfType(typeof(Grunt));
		Hero = grunt.GetComponent<Grunt>();
	}

	private IEnumerator Change()
	{
		_trig = false;
		GruntSource.Get().SetCurrentLevel = 1;
		GruntSource.Get().ExperienceToZero();
		//Parameters.PointExpir++;
		yield return new WaitForSeconds(0.2f);
		_trig = true;
		//Swaper.CallMenu();
		Hero.GetMouse();
	}

	private void Update()
	{
		Self.value = GruntSource.Get().GetExperience / GruntSource.Get().MaxExperienceValue;
		switch (Parameters.Level)
		{
		case 1:
			GruntSource.Get().MaxExperienceValue = 120;
			break;
		case 2:
			GruntSource.Get().MaxExperienceValue = 230;
			break;
		case 3:
			GruntSource.Get().MaxExperienceValue = 360;
			break;
		case 4:
			GruntSource.Get().MaxExperienceValue = 480;
			break;
		case 5:
			GruntSource.Get().MaxExperienceValue = 510;
			break;
		case 6:
			GruntSource.Get().MaxExperienceValue = 870;
			break;
		case 7:
			GruntSource.Get().MaxExperienceValue = 1250;
			break;
		case 8:
			GruntSource.Get().MaxExperienceValue = 1890;
			break;
		case 9:
			GruntSource.Get().MaxExperienceValue = 2400;
			break;
		case 10:
			GruntSource.Get().MaxExperienceValue = 3700;
			break;
		case 11:
			GruntSource.Get().MaxExperienceValue = 4100;
			break;
		case 12:
			GruntSource.Get().MaxExperienceValue = 5500;
			break;
		case 13:
			GruntSource.Get().MaxExperienceValue = 6490;
			break;
		case 14:
			GruntSource.Get().MaxExperienceValue = 8210;
			break;
		case 15:
			GruntSource.Get().MaxExperienceValue = 9750;
			break;
		case 16:
			GruntSource.Get().MaxExperienceValue = 12000;
			break;
		case 17:
			GruntSource.Get().MaxExperienceValue = 15400;
			break;
		case 18:
			GruntSource.Get().MaxExperienceValue = 45000;
			break;
		case 19:
			GruntSource.Get().MaxExperienceValue = 275400;
			break;
		}
		if (GruntSource.Get().GetExperience >= GruntSource.Get().MaxExperienceValue && _trig)
		{
			StartCoroutine(Change());
		}
	}
}
