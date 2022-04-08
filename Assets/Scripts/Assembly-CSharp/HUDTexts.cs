using UnityEngine;
using UnityEngine.UI;

public class HUDTexts : MonoBehaviour
{
	public enum List
	{
		MouseText,
		SoundText,
		LoadText,
		SaveText,
		ExitText,
		WarningText,
		AdviceText,
		NewLevel
	}

	public List Blocks;

	[HideInInspector]
	public Text _self;

	private void Start()
	{
		_self = GetComponent<Text>();
	}

	private void Update()
	{
		switch (Blocks)
		{
		case List.MouseText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Mouse Speed";
				break;
			case 1:
				_self.text = "Скорость Мыши";
				break;
			}
			break;
		case List.SoundText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Sounds Volume";
				break;
			case 1:
				_self.text = "Громкость Звука";
				break;
			}
			break;
		case List.LoadText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Load game";
				break;
			case 1:
				_self.text = "Загрузить игру";
				break;
			}
			break;
		case List.SaveText:
			switch (Settings.Language)
			{
				case 0:
					_self.text = "Save game";
					break;
				case 1:
					_self.text = "Сохранить игру";
					break;
			}
			break;
			case List.ExitText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Exit to Menu";
				break;
			case 1:
				_self.text = "Выйти в Меню";
				break;
			}
			break;
		case List.WarningText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "You lose";
				break;
			case 1:
				_self.text = "Вы проиграли";
				break;
			}
			break;
		case List.AdviceText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Never give up and try again!";
				break;
			case 1:
				_self.text = "Никогда не сдавайтесь и пробуй снова!";
				break;
			}
			break;
		case List.NewLevel:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "New level!";
				break;
			case 1:
				_self.text = "Новый уровень!";
				break;
			}
			break;
		}
	}
}
