using UnityEngine;

public class MenuSwaper : MonoBehaviour
{
	public GameObject Game;

	public GameObject Pause;

	public GameObject GameOver;

	public GameObject Pump;

	private bool _active = true;

	[HideInInspector]
	public Grunt Hero;

	[HideInInspector]
	public RandomMusic GetMusic;

	private void Start()
	{
		Grunt grunt = (Grunt)Object.FindObjectOfType(typeof(Grunt));
		Hero = grunt.GetComponent<Grunt>();
		RandomMusic randomMusic = (RandomMusic)Object.FindObjectOfType(typeof(RandomMusic));
		GetMusic = randomMusic.GetComponent<RandomMusic>();
	}

	public void ReturnToGame()
	{
		_active = true;
		Parameters.Pause = !_active;
		Pump.SetActive(!_active);
		Game.SetActive(_active);
		Pause.SetActive(!_active);
		Hero.GetMouse();
		GetMusic.MusicState(_active);
	}

	public void CallMenu()
	{
		_active = false;
		Parameters.Pause = !_active;
		Pump.SetActive(!_active);
		Game.SetActive(_active);
		Pause.SetActive(_active);
		GetMusic.MusicState(_active);
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.Escape) && Parameters.Health > 0 && !Parameters.Pause)
		{
			_active = !_active;
			Game.SetActive(_active);
			Pause.SetActive(!_active);
			GetMusic.MusicState(_active);
		}
		if (!_active)
		{
			Time.timeScale = 0f;
		}
		if (_active)
		{
			Time.timeScale = 1f;
		}
		if (Parameters.Health < 1)
		{
			Parameters.Pause = false;
			GameOver.SetActive(true);
			Game.SetActive(false);
			Pause.SetActive(false);
			Time.timeScale = 0f;
		}
	}
}
