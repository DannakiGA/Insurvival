using System.Collections;
using UnityEngine;

public class Grunt : MonoBehaviour
{
	const float gravitySpeed = 0.5f;

	public float Speed;
	public float MouseSensitivity;
	public Camera HeroHead;
	public LayerMask Mask;

	bool isTeleported;
	bool grounded;
	CharacterController controller;
	float rotateAmountX;
	float rotateAmountY;
	Vector3 moveVector;
	RaycastHit hitInfo;

	Vector3 playerPosition => transform.position;
	Quaternion playerRotation => transform.rotation;

	void Start()
	{
		controller = GetComponent<CharacterController>();
		//Source = GetComponent<AudioSource>();
		CursorLock(true);
		Speed = 6 + Parameters.AddSpeed;

		GruntSource.Get().onPlayerPositionChange += PlayerPositionChange;
		GruntSource.Get().onPlayerPosition = playerPosition;
		GruntSource.Get().onPlayerRotation = playerRotation;
	}

	void CursorLock(bool state)
	{
		Cursor.visible = !state;
		switch(state)
        {
			case true:
				Cursor.lockState = CursorLockMode.Locked;
				break;
			case false:
				Cursor.lockState = CursorLockMode.None;
				break;
		}
	}

	public void GetMouse()
	{
		//SetCursorLock(!IsLocked);
	}

	void Rotate()
	{
		rotateAmountX += Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
		rotateAmountY += Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
		rotateAmountY = Mathf.Clamp(rotateAmountY, -60f, 60f);
		transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, rotateAmountX, 0f);
		HeroHead.transform.rotation = Quaternion.Euler(-rotateAmountY, HeroHead.transform.rotation.eulerAngles.y, 0);
	}

	public IEnumerator CollisionOff()
	{
		isTeleported = !isTeleported;
		controller.enabled = !isTeleported;
		yield return new WaitForSeconds(0.06f);
		isTeleported = !isTeleported;
		controller.enabled = !isTeleported;
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

	void Movement()
	{
		//grounded = Physics.Raycast(transform.position, Vector3.down, out hitInfo, 2f, Mask.value);
		grounded = controller.isGrounded;

		moveVector.x = Input.GetAxis("Horizontal") * Speed;
		if (!grounded) moveVector.y -= gravitySpeed;
		moveVector.z = Input.GetAxis("Vertical") * Speed;
		moveVector = transform.TransformDirection(moveVector);
	}

	void Update()
	{
		Movement();
		Rotate();
		Speed = 6 + Parameters.AddSpeed;
		controller.Move(moveVector * Time.deltaTime);
	}
}
