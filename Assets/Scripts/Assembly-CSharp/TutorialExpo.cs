using UnityEngine;
using UnityEngine.UI;

public class TutorialExpo : MonoBehaviour
{
	[HideInInspector]
	public Text _self;

	private void Start()
	{
		_self = GetComponent<Text>();
	}

	private void Update()
	{
		switch (Settings.Language)
		{
		case 0:
			_self.text = "This menu automatically and gives you the opportunity to change the characteristics of your character, with each new level. To select the one you need, just click on the image \"Stiki\".\nDescription:\n\"Stiki running \" - adds speed to your movement.\n\"Stiki with barbell\" - adds additional damage from your weapon.\n\"Stiki with shield\" - the necessary additional units for health.";
			break;
		case 1:
			_self.text = "Данное меню появляется автоматически и дает вам возможности изменить характеристики вашего персонажа, с каждым новым уровнем. Что бы выбрать нужную, достаточно нажать на изображение \"Стики\".\nОписание:\n\"Стики бежит\" - добавляет скорости к вашему передвижению.\n\"Стики со штангой\" - добавляет дополнительный урон от вашего оружия.\n\"Стики со щитом\" - добавляет дополнительные единицы к здоровью.";
			break;
		}
	}
}
