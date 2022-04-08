using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
	public int NextLevelNumber;

	public void MoveToNextLevel()
	{
		SceneManager.LoadScene(NextLevelNumber);
	}
}
