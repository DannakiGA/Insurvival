using System.Linq;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerParameters
{
    Weapons weapon; //Which a type of weapon in the hands;
    List<ItemBase<Weapons>> weapons = new List<ItemBase<Weapons>>();
    List<ItemBase<Ammunition>> ammunitions = new List<ItemBase<Ammunition>>();
    List<ItemBase<GruntProperty>> properties = new List<ItemBase<GruntProperty>>();

    Vector3 position;
    Quaternion rotation;
    int radiationLevel;
    int health;
    int maxHealth;
    int maxExperience;
    int experience;
    int currentLevel;

    public PlayerParameters() { }

    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            if (health + value > maxHealth)
            {
                health = maxHealth;
            }
            else
            {
                health += value;
            }
        }
    }
    public int RadiationLevel
    {
        get
        {
            return radiationLevel;
        }
        set
        {
            if (radiationLevel + value >= 100)
            {
                radiationLevel = 100;
            }
            else
            {
                radiationLevel = value;
            }
        }
    }
    public int Experience { get { return experience; } set { experience += value; } }
    public int CurrentLevel { get { return currentLevel; } set { currentLevel += value; } }
    public int MaxExperience { get { return maxExperience; } set { maxExperience = value; } }
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

    public Vector3 Position
    {
        get
        {
            return position;
        }

        set
        {
            position = value;
        }
    }
    public Quaternion Rotation
    {
        get
        {
            return rotation;
        }

        set
        {
            rotation = value;
        }
    }


    public void Start(Vector3 startposition, Quaternion startrotation)
    {
        position = startposition;
        rotation = startrotation;
        health = 70;
        maxHealth = 100;
        experience = 0;
        currentLevel = 0;
        radiationLevel = 0;
        maxExperience = 1;
        weapon = Weapons.None;
    }

    public void LoadPlayer(PlayerParameters loadedPlayer)
    {
        weapon = loadedPlayer.weapon;
        weapons = loadedPlayer.weapons;
        ammunitions = loadedPlayer.ammunitions;
        properties = loadedPlayer.properties;
        position = loadedPlayer.position;
        rotation = loadedPlayer.rotation;
        radiationLevel = loadedPlayer.radiationLevel;
        health = loadedPlayer.health;
        maxHealth = loadedPlayer.maxHealth;
        experience = loadedPlayer.experience;
        currentLevel = loadedPlayer.currentLevel;
        maxExperience = loadedPlayer.maxExperience;
        Debug.Log($"{position}, {rotation}, {weapon}, {health}");
    }

    //Add a weapon to the player or set a new count of ammo;
    public void AddWeapon(Weapons weapon, int ammo)
    {
        var getWeapon = from i in weapons
                        where i.EqualItem(weapon)
                        select i;

        foreach (var element in getWeapon)
        {
            if (weapons.Contains(element))
            {
                element.Count = ammo;
            }
            else
            {
                weapons.Add(new ItemBase<Weapons>(weapon, ammo));
            }
        }
    }

    //Add an ammunition to the player or set a new count of ammunition;
    public void AddAmmunition(Ammunition ammunition, int count)
    {
        var getAmmunition = from i in ammunitions
                            where i.EqualItem(ammunition)
                            select i;

        foreach (var element in getAmmunition)
        {
            if (ammunitions.Contains(element))
            {
                element.Count = count;
            }
            else
            {
                ammunitions.Add(new ItemBase<Ammunition>(ammunition, count));
            }
        }
    }

    //Add a property to the player or set a new count of current;
    public void AddProperty(GruntProperty property, int count)
    {
        var getProperty = from i in properties
                          where i.EqualItem(property)
                          select i;

        foreach (var element in getProperty)
        {
            if (properties.Contains(element))
            {
                element.Count = count;
            }
            else
            {
                properties.Add(new ItemBase<GruntProperty>(property, count));
            }
        }
    }

    //To low some ammunition or some ammo;
    public void SubtractAmmo(Weapons weapon, int substractValue)
    {
        var getWeapon = from i in weapons
                        where i.EqualItem(weapon)
                        select i;
        if (getWeapon == null) return;

        foreach (var element in getWeapon)
        {
            element.Count = -substractValue;
        }
    }

    public void SubtractAmmunition(Ammunition ammunition, int substractValue)
    {
        var getAmmunition = from i in ammunitions
                            where i.EqualItem(ammunition)
                            select i;
        if (getAmmunition == null) return;

        foreach (var element in getAmmunition)
        {
            element.Count = -substractValue;
        }
    }

    //Set to zero some experience and some radiation;
    public void ToZeroExperience()
    {
        experience = 0;
    }

    public void ToZeroRadiation()
    {
        radiationLevel = 0;
    }
}
