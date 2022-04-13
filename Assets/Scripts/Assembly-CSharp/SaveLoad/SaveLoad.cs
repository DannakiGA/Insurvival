using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    PlayerParameters currentPlayer = new PlayerParameters();

	public void Save()
	{
		currentPlayer = GruntSource.Get().Player;
		currentPlayer.Position = GruntSource.Get().onPlayerPosition;
		currentPlayer.Rotation = GruntSource.Get().onPlayerRotation;
	}

	public void Load()
	{
		GruntSource.Get().Player = currentPlayer;
		GruntSource.Get().onPlayerPositionChange.Invoke(GruntSource.Get().Player.Position, GruntSource.Get().Player.Rotation);
	}
}
