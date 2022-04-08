using UnityEngine;
using UnityEngine.UI;

public class SouthfleetTexts : MonoBehaviour
{
	public enum List
	{
		FirstText,
		SecondText,
		ThirdText,
		FourText
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
				_self.text = "Cutting from the newspaper:\nIn your place I would not focus on this issue. Now is 2009, and there are no prerequisites for the fact that the world will be inhabited by so-called zombies, let alone the fact that we should live in shelters. Are you joking right?";
				break;
			case 1:
				_self.text = "Вырезка из газеты:\nНа вашем бы месте я не акцентировала бы внимание на данной проблеме. Сейчас 2009 год, и нет никаких предпосылок к тому, что мир будут населять так называемые зомби, а уж про то, что мы должы жить в убежищах. Вы верно шутите?";
				break;
			}
			break;
		case List.SecondText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Cutting from the newspaper:\nReportedly, the man's name is Mike, with him there was information about some kind of complex 228 and the development of psyche, with the aim of improving human characteristics...";
				break;
			case 1:
				_self.text = "Вырезка из газеты:\nКак сообщается, человека зовут Майк, с ним были сведения о каком-то комплексе 228 и разработках псивоздействия, с целью улучшения человеческих особенностей...";
				break;
			}
			break;
		case List.ThirdText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Cutting from the newspaper:\nA shelter for homeless cats will be built on the site of the long-abandoned Club 69. In the UK, take care of animals. Our Queen herself likes cats very much...";
				break;
			case 1:
				_self.text = "Вырезка из газеты:\nНа месте, давно заброшенного Клуба 69 будет построен приют для бездомных кошек. В Великобритании заботятся о животных. Наша Королева сама любит очень кошек...";
				break;
			}
			break;
		case List.FourText:
			switch (Settings.Language)
			{
			case 0:
				_self.text = "Cutting from the personal diary of the girl Miki: \n... Dad said that we will return to Grandma in Luddesdown. It will be very sad for me without my bear Cody, as soon as possible we would return to the granny...";
				break;
			case 1:
				_self.text = "Вырезка из личного дневника девочки Мики:\n...Папа сказал что мы еще вернемся к бабушке в Лютстаун. Мне будет очень грусно без моего мишки Коди, поскорее бы мы вернулись к бабуле...";
				break;
			}
			break;
		}
	}
}
