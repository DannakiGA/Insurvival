using UnityEngine;

public class ButtonsAdded : MonoBehaviour
{
	private void Start()
	{
	}

	public void AddingHealth()
	{
		if (Parameters.PointExpir > 0)
		{
			Parameters.PointExpir--;
			Parameters.AddHealth++;
			Parameters.Health = Parameters.Max + Parameters.AddHealth;
		}
	}

	public void AddingDamage()
	{
		if (Parameters.PointExpir > 0)
		{
			Parameters.PointExpir--;
			Parameters.AddDamage++;
		}
	}

	public void AddingSpeed()
	{
		if (Parameters.PointExpir > 0)
		{
			Parameters.PointExpir--;
			Parameters.AddSpeed++;
		}
	}

	private void Update()
	{
	}
}
