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
		Parameters.Level++;
		Parameters.exp = 0f;
		Parameters.PointExpir++;
		yield return new WaitForSeconds(0.2f);
		_trig = true;
		Swaper.CallMenu();
		Hero.GetMouse();
	}

	private void Update()
	{
		Self.value = Parameters.exp / Parameters.max_exp;
		switch (Parameters.Level)
		{
		case 1:
			Parameters.max_exp = 120f;
			break;
		case 2:
			Parameters.max_exp = 230f;
			break;
		case 3:
			Parameters.max_exp = 360f;
			break;
		case 4:
			Parameters.max_exp = 480f;
			break;
		case 5:
			Parameters.max_exp = 510f;
			break;
		case 6:
			Parameters.max_exp = 870f;
			break;
		case 7:
			Parameters.max_exp = 1250f;
			break;
		case 8:
			Parameters.max_exp = 1890f;
			break;
		case 9:
			Parameters.max_exp = 2400f;
			break;
		case 10:
			Parameters.max_exp = 3700f;
			break;
		case 11:
			Parameters.max_exp = 4100f;
			break;
		case 12:
			Parameters.max_exp = 5500f;
			break;
		case 13:
			Parameters.max_exp = 6490f;
			break;
		case 14:
			Parameters.max_exp = 8210f;
			break;
		case 15:
			Parameters.max_exp = 9750f;
			break;
		case 16:
			Parameters.max_exp = 12000f;
			break;
		case 17:
			Parameters.max_exp = 15400f;
			break;
		case 18:
			Parameters.max_exp = 45000f;
			break;
		case 19:
			Parameters.max_exp = 275400f;
			break;
		}
		if (Parameters.exp >= Parameters.max_exp && _trig)
		{
			StartCoroutine(Change());
		}
	}
}
