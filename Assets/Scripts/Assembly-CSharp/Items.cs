using UnityEngine;

public class Items : MonoBehaviour
{
	public enum List
	{
		Medkit,
		Bandage,
		StopRad,
		MutatorSpeed,
		MutatorHealth,
		MutatorDamage,
		Bullets,
		Shells,
		Pack,
		Axe,
		Beretta,
		Double,
		Sig,
		Minigun
	}

	public List Item;

	[HideInInspector]
	public InformerScript Notification;

	[HideInInspector]
	public GID TextAlert;

	[HideInInspector]
	public Inventory UpdateInformation;

	[HideInInspector]
	public Changer Refresh;

	[HideInInspector]
	public string MessageInBox;

	private void Start()
	{
		InformerScript informerScript = (InformerScript)Object.FindObjectOfType(typeof(InformerScript));
		GID gID = (GID)Object.FindObjectOfType(typeof(GID));
		Changer changer = (Changer)Object.FindObjectOfType(typeof(Changer));
		Notification = informerScript.GetComponent<InformerScript>();
		TextAlert = gID.GetComponent<GID>();
		Refresh = changer.GetComponent<Changer>();
	}

	private void InformationToPlayer()
	{
		Notification.GetItem();
		TextAlert.SendTitle(MessageInBox);
		Object.Destroy(base.gameObject);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!(other.tag == "Player"))
		{
			return;
		}
		switch (Item)
		{
		case List.Medkit:
			Parameters.Medkit++;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up medkit";
				break;
			case 1:
				MessageInBox = "Вы подобрали аптечку";
				break;
			}
			InformationToPlayer();
			break;
		case List.Bandage:
			Parameters.Bandage++;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up bandage";
				break;
			case 1:
				MessageInBox = "Вы подобрали бинт";
				break;
			}
			InformationToPlayer();
			break;
		case List.StopRad:
			Parameters.StopRad++;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up StopRad";
				break;
			case 1:
				MessageInBox = "Вы подобрали СтопРад";
				break;
			}
			InformationToPlayer();
			break;
		case List.MutatorSpeed:
			Parameters.AddSpeed++;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up serum of speed";
				break;
			case 1:
				MessageInBox = "Вы подобрали сыворотку скорости";
				break;
			}
			InformationToPlayer();
			break;
		case List.MutatorHealth:
			Parameters.AddHealth++;
			Parameters.Health = Parameters.Max + Parameters.AddHealth;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up serum of resistance";
				break;
			case 1:
				MessageInBox = "Вы подобрали сыворотку устойчивости";
				break;
			}
			InformationToPlayer();
			break;
		case List.MutatorDamage:
			Parameters.AddDamage++;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up serum of gain";
				break;
			case 1:
				MessageInBox = "Вы подобрали сыворотку усиления";
				break;
			}
			InformationToPlayer();
			break;
		case List.Bullets:
			Parameters.ammo_chaingun += 12;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up small-caliber ammunition: 12";
				break;
			case 1:
				MessageInBox = "Вы подобрали патроны мелкого калибра: 12";
				break;
			}
			InformationToPlayer();
			break;
		case List.Shells:
			Parameters.ammo_shotgun += 8;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up a shotgun ammunition: 8";
				break;
			case 1:
				MessageInBox = "Вы подобрали патроны для ружья: 8";
				break;
			}
			InformationToPlayer();
			break;
		case List.Pack:
			Parameters.ammo_minigun += 120;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up large-caliber ammunition: 120";
				break;
			case 1:
				MessageInBox = "Вы подобрали патроны крупного калибра: 120";
				break;
			}
			InformationToPlayer();
			break;
		case List.Axe:
			Parameters.weapon_axe = true;
			Parameters.CurrentWeapon = 0;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up pipe how weapon";
				break;
			case 1:
				MessageInBox = "Вы подобрали трубу как оружие";
				break;
			}
			InformationToPlayer();
			Refresh.UpdateWeapon();
			break;
		case List.Beretta:
			Parameters.weapon_beretta = true;
			Parameters.CurrentWeapon = 1;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up Beretta";
				break;
			case 1:
				MessageInBox = "Вы подобрали Беретту";
				break;
			}
			InformationToPlayer();
			Refresh.UpdateWeapon();
			break;
		case List.Double:
			Parameters.weapon_double = true;
			Parameters.CurrentWeapon = 2;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up Double-bar";
				break;
			case 1:
				MessageInBox = "Вы подобрали Двухстволку";
				break;
			}
			InformationToPlayer();
			Refresh.UpdateWeapon();
			break;
		case List.Sig:
			Parameters.weapon_sig = true;
			Parameters.CurrentWeapon = 3;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up SIG";
				break;
			case 1:
				MessageInBox = "Вы подобрали SIG";
				break;
			}
			InformationToPlayer();
			Refresh.UpdateWeapon();
			break;
		case List.Minigun:
			Parameters.weapon_minigun = true;
			Parameters.CurrentWeapon = 4;
			switch (Settings.Language)
			{
			case 0:
				MessageInBox = "You picked up minigun";
				break;
			case 1:
				MessageInBox = "Вы подобрали миниган";
				break;
			}
			InformationToPlayer();
			Refresh.UpdateWeapon();
			break;
		}
	}
}
