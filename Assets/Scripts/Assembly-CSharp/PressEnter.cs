using UnityEngine;
using UnityEngine.UI;

public class PressEnter : MonoBehaviour
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
			_self.text = "Press \"Enter\" to close message";
			break;
		case 1:
			_self.text = "Нажмите \"Enter\" для закрытия сообщения";
			break;
		}
	}
}
