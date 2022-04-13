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

    //Return the player for save;
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

    public void StartPlayer(Vector3 startposition, Quaternion startrotation) //Then a game started; new game;
    {
        player.Start(startposition, startrotation);
    }

    //Get some value of grunt (like rpg);
    public int GetHealthValue { get { return player.Health; } }
    public int GetRadiationLevel { get { return player.RadiationLevel; } }
    public int GetExperience { get { return player.Experience; } }
    public int GetCurrentLevel { get { return player.CurrentLevel; } }

    //Set some value of grunt;
    public int SetHealthValue { set { player.Health = value; } }
    public int SetRadiationLevel { set { player.RadiationLevel = value; } }
    public int SetExperience { set { player.Experience = value; } }
    public int SetCurrentLevel { set { player.CurrentLevel = value; } }

    public int MaxExperienceValue { get { return player.MaxExperience; } set { player.MaxExperience = value; } }

    //Weapon;
    public void AddWeaponOrAmmo(Weapons weapon, int ammo) => player.AddWeapon(weapon, ammo);
    public void SubstractAmmo(Weapons weapon, int ammo) => player.SubtractAmmo(weapon, ammo);
    public Weapons CurrentWeaponInHands { get { return player.Weapon; } set { player.Weapon = value; } }

    //Ammunition;
    public void AddItemToInventory(Ammunition ammunition, int count) => player.AddAmmunition(ammunition, count);
    public void SubstractAmmunition(Ammunition ammunition, int count) => player.SubtractAmmunition(ammunition, count);

    //Stats(properties);
    public void UpdateProperty(GruntProperty property, int count) => player.AddProperty(property, count);

    //Set to zero some experience and some radiation;
    public void RadiationToZero() => player.ToZeroRadiation();
    public void ExperienceToZero() => player.ToZeroExperience();
}
