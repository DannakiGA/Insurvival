using System;
using UnityEngine;

public enum Weapons
{
    Pipe,
    Gun12mm,
    Double,
    Sig,
    Minigun,
    None
}

public enum Ammunition
{
    Bandage,
    Medkit,
    Antirad
}

public enum GruntProperty
{
    HealthBonus,
    DamageBonus,
    SpeedBonus
}

public class GruntSource
{
    static GruntSource Instance;
    PlayerParameters player = new PlayerParameters();
    public static GruntSource Get()
    {
        if(Instance == null)
        {
            Instance = new GruntSource();
        }
        return Instance;
    }

    public PlayerParameters Player
    {
        get
        {
            return player;
        }

        set
        {
            player.LoadPlayer(value);
            Debug.Log("Loading");
        }
    }

    public Action<Vector3, Quaternion> onPlayerPositionChange;
    public Vector3 onPlayerPosition;
    public Quaternion onPlayerRotation;

    public bool FreezePlayer = false;
}
