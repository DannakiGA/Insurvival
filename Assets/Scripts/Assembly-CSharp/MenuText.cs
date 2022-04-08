using UnityEngine;
using UnityEngine.UI;

public class MenuText : MonoBehaviour
{
	public enum List
	{
		NewButton,
		LoadButton,
		SettingButton,
		TrainingButton,
		QuitButton,
		SizeText,
		FullText,
		MouseText,
		SoundText,
		LangText,
		ReturnText
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
		case List.NewButton:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "New";
				break;
			case 1:
				_self.text = "Новая";
				break;
			}
			break;
		case List.LoadButton:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Load";
				break;
			case 1:
				_self.text = "Загрузить";
				break;
			}
			break;
		case List.SettingButton:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Setting";
				break;
			case 1:
				_self.text = "Настройки";
				break;
			}
			break;
		case List.TrainingButton:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Training";
				break;
			case 1:
				_self.text = "Обучение";
				break;
			}
			break;
		}
		switch (Blocks)
		{
		case List.QuitButton:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Quit";
				break;
			case 1:
				_self.text = "Выход";
				break;
			}
			break;
		case List.SizeText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Screen Size";
				break;
			case 1:
				_self.text = "Размер Экрана";
				break;
			}
			break;
		case List.FullText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Fullscreen";
				break;
			case 1:
				_self.text = "Полный Экран";
				break;
			}
			break;
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
		case List.LangText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Language";
				break;
			case 1:
				_self.text = "Язык";
				break;
			}
			break;
		case List.ReturnText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Press ESC to return back";
				break;
			case 1:
				_self.text = "Нажмите ESC что бы вернуться обратно";
				break;
			}
			break;
		}
	}
}
