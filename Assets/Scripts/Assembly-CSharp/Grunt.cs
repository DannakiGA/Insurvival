using System.Collections;
using UnityEngine;

public class Grunt : MonoBehaviour
{
	[HideInInspector]
	public float Speed;

	[HideInInspector]
	public Vector3 Remove;

	public Camera HeroHead;

	[HideInInspector]
	public float MouseSensitiv;

	public bool IsLocked;

	private bool isTeleported;

	private CharacterController Controller;

	private float RotateAmountX;

	private float RotateAmountY;

	private AudioSource Source;

	private void Start()
	{
		Controller = GetComponent<CharacterController>();
		Source = GetComponent<AudioSource>();
		SetCursorLock(true);
		Speed = 6 + Parameters.AddSpeed;

		GruntSource.Get().onPlayerPositionChange += PlayerPositionChange;
		GruntSource.Get().onPlayerPosition = PlayerPosition;
		GruntSource.Get().onPlayerRotation = PlayerRotation;
	}

	private void SetCursorLock(bool IsLocked)
	{
		this.IsLocked = IsLocked;
		Screen.lockCursor = IsLocked;
		Cursor.visible = !IsLocked;
	}

	public void GetMouse()
	{
		SetCursorLock(!IsLocked);
	}

	private void Rotate()
	{
		if (Input.GetKeyUp(KeyCode.Escape) && !Parameters.Pause)
		{
			SetCursorLock(!IsLocked);
		}
		RotateAmountX += Input.GetAxis("Mouse X") * MouseSensitiv * Time.deltaTime;
		if (RotateAmountY > 60f)
		{
			RotateAmountY = 60f;
		}
		if (RotateAmountY < -60f)
		{
			RotateAmountY = -60f;
		}
		base.transform.rotation = Quaternion.Euler(base.transform.rotation.eulerAngles.x, RotateAmountX, 0f);
		if (IsLocked)
		{
			MouseSensitiv = Settings.Mouse;
		}
		else
		{
			MouseSensitiv = 0f;
		}
	}

	public IEnumerator CollisionOff()
	{
		isTeleported = !isTeleported;
		Controller.enabled = !isTeleported;
		yield return new WaitForSeconds(0.06f);
		isTeleported = !isTeleported;
		Controller.enabled = !isTeleported;
	}

	public void Teleported(Vector3 TeleportPosition)
	{
		StartCoroutine(CollisionOff());
		base.transform.position = TeleportPosition;
	}

	void PlayerPositionChange(Vector3 position, Quaternion rotation)
	{
		StartCoroutine(CollisionOff());
		transform.position = position;
		transform.rotation = rotation;
	}

	Vector3 PlayerPosition
    {
        get
        {
			return transform.position;

		}
    }

	Quaternion PlayerRotation
    {
		get
        {
			return transform.rotation;
        }
    }

	private void GetMove()
	{
		if (!isTeleported)
		{
			Remove.x = Input.GetAxis("Horizontal") * Speed;
			Remove.z = Input.GetAxis("Vertical") * Speed;
			Remove = base.transform.TransformDirection(Remove);
		}
	}

	private void Update()
	{
		GetMove();
		Rotate();
		Speed = 6 + Parameters.AddSpeed;
	}

	private void FixedUpdate()
	{
		Controller.Move(Remove * Time.fixedDeltaTime);
	}
}
