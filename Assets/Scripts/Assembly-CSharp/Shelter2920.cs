using UnityEngine;
using UnityEngine.UI;

public class Shelter2920 : MonoBehaviour
{
	public enum List
	{
		FirstText,
		SecondText,
		ThirdText
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
		case List.FirstText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Initializing user. \nWelcome Frank Hoss. \n One message: \n \"Frank, if you read this message, it means you survived. I’m so glad our future was saved! We didn’t save the rest, but we managed to save you It came to us like that, and some of the staff began to experience hallucinations, Dory began to open cryocameras, and kill your team, we only managed to save you. Listen, I will write you your goal, and then I will lock this room. happen, maybe we all become zombies. It’s close now. Go upstairs to the Southfleet, and from there, make your way through New Barn in Shelter 3909, there is a program to restore Great Britain. And to me it's time to go, I see the children of darkness.\"";
				break;
			case 1:
				_self.text = "Инициализация пользователя.\n Добро пожаловать Френк Хосс.\n Одно сообшение:\n\"Френк, если ты читаешь это сообщение, значит ты все же выжил. Я так рад, наше будущее спасено! Мы не сберегли остальных, но удалось тебя сберечь. Оно как то пробралось к нам, и часть персонала стала испытывать галлюцинации, Дори начала открывать криокамеры, и убивать твою команду, нам удалось только тебя, спасти. Послушай, я напишу тебе твою цель, а дальше запру эту комнату. Я не знаю что произойдет, возможно все мы станем зомби. Оно уже близко. Поднимайся наверх, в Соутфлит, а оттуда, чрез Нью Барн проберись в Убежище 3909, там находится программа по восстановлению Великобритании. А мне, пора уходить, я уже вижу детей из темноты.\"";
				break;
			}
			break;
		case List.SecondText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Around the enemies, I had to kill those who are in the cryochamber. They saved one. But I’ll get out and program robots to kill this Frank. It told me he must die. This Heart, his heart, should belong to all of us.";
				break;
			case 1:
				_self.text = "Кругом враги, я должна была убить тех, кто находится в криокамере. Одного они спасли. Но я выберусь, и запрограммирую роботов на убийство этого Френка. Оно мне велело, он должен умереть. Это Сердце, его сердце, должно принадлежать всем нам.";
				break;
			}
			break;
		case List.ThirdText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "\"... robots were placed on the surface to eliminate the anomalous manifestations of human and animal mutations. The robots were equipped with power boards, but over time their protection will subside, and the shield can be pierced even with an ordinary stone. I will hope that their program will not fail, by the time they leave the shelters, and they will not accept us as enemies. But what I want ...\"";
				break;
			case 1:
				_self.text = "\"...на поверхности были размещены роботы, для уничтожения аномальных проявлений мутаций человека и животных. Роботы были оснащены энергощитами, но со временем их защита будет спадать, и щит можно будет пробить даже обычным камнем. Я буду надеяться что их программа не собьется, к моменту покидания убежищ, и они не воспримут нас врагами. Но что мне хочется...\"";
				break;
			}
			break;
		}
	}
}
