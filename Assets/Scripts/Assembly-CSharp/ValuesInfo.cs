using UnityEngine;
using UnityEngine.UI;

public class ValuesInfo : MonoBehaviour
{
	public enum Points
	{
		Health,
		Speed,
		Damage,
		Point
	}

	[HideInInspector]
	public Text Self;

	public Points Values;

	private void Start()
	{
		Self = GetComponent<Text>();
	}

	private void Update()
	{
		switch (Values)
		{
		case Points.Health:
			Self.text = string.Concat(Parameters.AddHealth);
			break;
		case Points.Speed:
			Self.text = string.Concat(Parameters.AddSpeed);
			break;
		case Points.Damage:
			Self.text = string.Concat(Parameters.AddDamage);
			break;
		case Points.Point:
			Self.text = string.Concat(Parameters.PointExpir);
			break;
		}
	}
}
