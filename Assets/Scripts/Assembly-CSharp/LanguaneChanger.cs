using UnityEngine;
using UnityEngine.UI;

public class LanguaneChanger : MonoBehaviour
{
	[HideInInspector]
	public Dropdown LangBox;

	private void Start()
	{
		LangBox = GetComponent<Dropdown>();
		LangBox.value = Settings.Language;
	}

	public void ValueChanged()
	{
		switch (LangBox.value)
		{
		case 0:
			Settings.Language = 0;
			break;
		case 1:
			Settings.Language = 1;
			break;
		}
	}

	private void Update()
	{
	}
}
