using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionSaver : MonoBehaviour
{
	public SaveGame Saving;

	public int Number;

	private void Start()
	{
		if (SceneManager.GetActiveScene().buildIndex != 0)
		{
			Saving.SceneNumber = Number;
			Saving.Save();
			Debug.Log("CurrentSceneSave" + Saving.SceneNumber);
		}
	}
}
