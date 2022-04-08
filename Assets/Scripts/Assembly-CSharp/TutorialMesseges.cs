using UnityEngine;
using UnityEngine.UI;

public class TutorialMesseges : MonoBehaviour
{
	public enum List
	{
		Walk,
		Hack,
		PipeTake,
		RadiationDamage,
		InfoRadiation,
		Weapon,
		Finaly,
		PauseText
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
		case List.Walk:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "To move, use the \"WASD\". Use \"Mouse\" for review. \nInterface: \nIn the upper left corner is information about your current level of development, below the experience bar, and even lower, statistics of current experience, and the amount of experience to reach a new level. Experience can be gained from killing a hostile creature, hacking a terminal, breaking a box. \nIn the lower left corner, there is information about your health status above the \"Heart\" icon, next to information about the state of radiation contamination above the \"Radiation Hazard Sign\" icon.\nFor further study go to the orange circle.";
				break;
			case 1:
				_self.text = "Для перемещения используйте \"WASD\". Для обзора используйте \"Мышь\".\nИнтерфейс:\nВ верхнем левом углу расположена информация о вашем текущем уровне развития, ниже полоска опыта, а еще ниже, статистика текущего опыта, и количество опыта для достижения нового уровня. Опыт можно получить от убийства враждебного существа, взлома терминала, разбития ящика.\nВ нижнем левом углу расположена информация о состоянии вашего здоровья над иконкой \"Сердца\", рядом идет информация о состоянии радиационного заражения над иконкой \"Знак Радиактивной Опасности\".\nДля дальнейшего обучения пройдите в оранжевый круг.";
				break;
			}
			break;
		case List.Hack:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "To perform any action, you should press the \"F\" key. This is usually in the case of moving to the next location or interacting with objects. \nSea key should be pressed multiple times to achieve success. \n Try to hack this terminal to open the door.";
				break;
			case 1:
				_self.text = "Что бы совершить какое-либо действие, вам следует нажать клавишу \"F\". Это как правило в случае перехода на следующую локацию или взаимодействия с объектами.\nПорою клавишу следует нажимать множество раз, для достижения успеха.\nПопробуйте взломать этот терминал для открытия двери.";
				break;
			}
			break;
		case List.PipeTake:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "See how many wooden boxes are here. Leave that breaking such, you can get something valuable. And here is the tool for this in the center. Just step on it to take it. \nTo hit, use the \"Left mouse button\".\nBy the way, the resources that fell from the box are taken using the same method.";
				break;
			case 1:
				_self.text = "Посмотрите как здесь много деревянных ящиков. Пологаю, что сломав такой, можно получить что-то ценное. А вот и инструмент для этого в центре. Просто наступите на него, что бы взять его.\nДля удара, используйте \"Левую кнопку мыши\".\nКстати, ресурсы выпавшие с ящика, подбираются таким же методом.";
				break;
			}
			break;
		case List.RadiationDamage:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Sometimes, you can get into the focus of radiation. You will be notified of this by the increasing importance of radioactive contamination. The first thing you need to do - leave the zone of radiation. Run forward to the orange circle.";
				break;
			case 1:
				_self.text = "Порою, вы можете попасть в очаг радиации. Об этом вас уведомит повышающееся значение радиактивного заражения. Первое что вы должны сделать - покинуть зону заражения. Пробегите вперед до оранжевого круга.";
				break;
			}
			break;
		case List.InfoRadiation:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "You have successfully left the radioactive impact area, now please press the key \"Esc\".";
				break;
			case 1:
				_self.text = "Вы успешно покинули зону радиактивного поражения, теперь пожалуйста нажмите клавишу \"Esc\".";
				break;
			}
			break;
		case List.Weapon:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "It is time to practice your shooting accuracy. To do this, pick up weapons and ammunition. To change the type of weapon, use the keys with the image of numbers on your keyboard. \nShoot at these barrels, it's fun. Just do not come close!";
				break;
			case 1:
				_self.text = "Настало время тренировки вашей меткости стрельбы. Для этого подберите оружие и патроны к нему. Что бы сменить тип оружия, используйте клавиши с изображением цифр на вашей клавиатуре.\nСтреляйте в эти бочки, это весело. Только не подходите близко!";
				break;
			}
			break;
		case List.Finaly:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Congratulations! You have completed the training process perfectly! Now start a new game by going to the main menu, from the pause menu. \nWonderful game for you!";
				break;
			case 1:
				_self.text = "Поздравляю! Вы прошли процесс обучения на отлично! Теперь начните новую игру, выйдя в главное меню, из меню паузы.\nПриятной Вам игры!";
				break;
			}
			break;
		case List.PauseText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "In the pause menu, you can see the number of items in the inventory. Just clicking on the image of the object, you use it. \nTo quickly use the object, without exiting the menu, press the following keys: \n \"Q\" - use the Bandage. \"E\" - used Medkit. \"R\" - use \"StopRad\".\nDescription of the items: \nMedkit - adds 50 health points, Bandage - adds 10 health points, \"StopRad\" - zeroes the level of radioactive damage. \nSo, in this menu, you can adjust the volume of sounds, mouse speed, go to the main menu, or restart the current location.";
				break;
			case 1:
				_self.text = "В меню паузы вы можете увидеть количество предметов в инвентаре. Так же нажав на изображение предмета, вы используете его.\nЧто бы быстро воспользоваться предметом, без выхода в меню, нажимайте следующие клавиши:\n\"Q\" - использовать Бинт. \"E\" - использоваться аптечку. \"R\" - использовать \"СтопРад\".\nОписание действия предметов:\nАптечка - прибавляет 50 единиц здоровья, Бинт - прибавляет 10 единиц здоровья, \"СтопРад\" - обнуляет уровень радиактивного заражения.\nТак же, в этом меню вы можете настроить уровень громкости звуков, скорость мыши, выйти в главное меню, или перезапустить текущую локацию.";
				break;
			}
			break;
		}
	}
}
