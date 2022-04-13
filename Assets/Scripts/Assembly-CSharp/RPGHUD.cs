using UnityEngine;
using UnityEngine.UI;

public class RPGHUD : MonoBehaviour
{
	public enum RPGGUI
	{
		LevelInfo,
		ExpInfo
	}

	[HideInInspector]
	public Text Self;

	public RPGGUI Texts;

	private void Start()
	{
		Self = GetComponent<Text>();
	}

	private void Update()
	{
		switch (Texts)
		{
		case RPGGUI.LevelInfo:
			switch (Settings.Language)
			{
			case 0:
				Self.text = "Level:::" + GruntSource.Get().GetCurrentLevel;
				break;
			case 1:
				Self.text = "Уровень:::" + GruntSource.Get().GetCurrentLevel;
				break;
			}
			break;
		case RPGGUI.ExpInfo:
			Self.text = $"[{GruntSource.Get().GetExperience}[]{Parameters.max_exp}]";
			break;
		}
	}
}
