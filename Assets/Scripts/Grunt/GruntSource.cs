using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Weapons
{
    Pipe,
    Gun12mm,
    Double,
    Sig,
    Minigun
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

[System.Serializable]
public class PlayerParameters
{
    Weapons weapon; //Which a type of weapon in the hands;
    List<ItemBase<Weapons>> weapons = new List<ItemBase<Weapons>>();
    List<ItemBase<Ammunition>> ammunitions = new List<ItemBase<Ammunition>>();
    List<ItemBase<GruntProperty>> properties = new List<ItemBase<GruntProperty>>();

    Vector3 positinon;
    Quaternion rotation;
    int radiationLevel;
    int health;
    int maxHealth;
    int experience;
    int currentLevel;

    public int Health { 
        get 
        { 
            return health; 
        } 

        set
        {
            if(value > maxHealth)
            {
                health = maxHealth;
            }
        }
    }
    public int RadiationLevel { get { return radiationLevel; } }
    public int Experience { get { return experience; } }
    public int CurrentLevel { get { return currentLevel; } }
    public Weapons Weapon
    {
        get
        {
            return weapon;
        }

        set
        {
            weapon = value;
        }
    }


    public void Start(Vector3 startposition, Quaternion startrotation)
    {
        positinon = startposition;
        rotation = startrotation;
        health = 70;
        maxHealth = 100;
        experience = 0;
        currentLevel = 0;
        radiationLevel = 0;
    }

    public void LoadPlayer(PlayerParameters loadedPlayer)
    {
        weapon = loadedPlayer.weapon;
        weapons = loadedPlayer.weapons;
        ammunitions = loadedPlayer.ammunitions;
        properties = loadedPlayer.properties;
        positinon = loadedPlayer.positinon;
        rotation = loadedPlayer.rotation;
        radiationLevel = loadedPlayer.radiationLevel;
        health = loadedPlayer.health;
        maxHealth = loadedPlayer.maxHealth;
        experience = loadedPlayer.experience;
        currentLevel = loadedPlayer.currentLevel;
    }

    //public void AddWeapon(Weapons weapon, int ammo)
    //{
    //    if(weapons.Contains(ItemBase<Weapons>))
    //    {
            
    //    }else
    //    {
    //        weapons.Add(new ItemBase<Weapons>(weapon, ammo));
    //    }
    //}

    //public void AddAmmunition(Ammunition ammunition, int count)
    //{
    //    if (this.ammunition.ContainsKey(ammunition))
    //    {
    //        int counts = 0;
    //        this.ammunition.TryGetValue(ammunition, out counts);
    //        counts += count;
    //        this.ammunition.Add(ammunition, counts);
    //    }
    //    else
    //    {
    //        this.ammunition.Add(ammunition, count);
    //    }
    //}
}

public class GruntSource
{
    static GruntSource Instance;
    PlayerParameters player = new PlayerParameters();

    public PlayerParameters Player
    {
        get
        {
            return player;
        }
    }

    public static GruntSource Get()
    {
        if(Instance == null)
        {
            Instance = new GruntSource();
        }
        return Instance;
    }

    public void StartPlayer(Vector3 startposition, Quaternion startrotation) //Then a game started; new game;
    {
        player.Start(startposition, startrotation);
    }

    public int ReturnHealthValue() => player.Health;
    public int ReturnRadiationLevel() => player.RadiationLevel;
    public int ReturnExperience() => player.Experience;
    public int ReturnCurrentLevel() => player.CurrentLevel;

}
