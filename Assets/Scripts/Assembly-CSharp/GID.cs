using UnityEngine;
using UnityEngine.UI;

public class GID : MonoBehaviour
{
	[HideInInspector]
	public Text Message;

	[HideInInspector]
	public float TimeToClear;

	[HideInInspector]
	public string Letter;

	private void Start()
	{
		Message = GetComponent<Text>();
	}

	public void SendTitle(string _message)
	{
		Letter = Letter + _message + "\n";
		TimeToClear = 0.4f;
	}

	private void Update()
	{
		Message.text = Letter;
		if (TimeToClear > 0f)
		{
			TimeToClear -= 0.3f * Time.deltaTime;
		}
		else
		{
			Letter = "";
		}
	}
}
