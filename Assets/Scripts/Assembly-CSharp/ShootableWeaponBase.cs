using System.Collections;
using UnityEngine;

public class ShootableWeaponBase : MonoBehaviour
{
	public AudioClip[] ShootSound;

	public float TimeBetweenShots;

	public float TimeForStartShoot;
	public float DamageStartTime;

	public float Range;

	public GameObject BloodParticle;

	public GameObject RobotParticle;

	Animator weaponAnimator;
	AudioSource weaponAudio;
	protected bool isCanShoot = true;

	Camera referenceCamera;

	public Camera ReferenceCamera
    {
        get
        {
			return referenceCamera;
        }
    }

    private void Awake()
    {
		referenceCamera = Camera.main;
	}

    private void Start()
	{
		weaponAnimator = GetComponent<Animator>();
		weaponAudio = GetComponent<AudioSource>();
	}

	private void OnEnable()
	{
		StartCoroutine(CanShoot());
	}

	protected IEnumerator Shoot(string trigger, int damageValue)
	{
		weaponAudio.volume = Settings.Sound;
		weaponAnimator.SetTrigger(trigger);
		weaponAudio.PlayOneShot(ShootSound[Random.Range(0, ShootSound.Length)]);
		yield return new WaitForSeconds(DamageStartTime);
		Damage(damageValue);
		yield return new WaitForSeconds(TimeBetweenShots);
		isCanShoot = true;
	}

	IEnumerator CanShoot()
	{
		isCanShoot = false;
		yield return new WaitForSeconds(TimeForStartShoot);
		isCanShoot = true;
	}

	void Damage(int damageValue)
	{

		int num = 1024;
		num = ~num;
		RaycastHit hitInfo;
		if (Physics.Raycast(referenceCamera.transform.position, referenceCamera.transform.forward, out hitInfo, Range, num) && hitInfo.collider != null)
		{
			if (hitInfo.collider.tag == "Robot")
			{
				Object.Instantiate(RobotParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
				hitInfo.collider.GetComponent<EnemyBase>().Hitting(damageValue + Parameters.AddDamage);
			}
			if (hitInfo.collider.tag == "Enemy")
			{
				Object.Instantiate(BloodParticle, hitInfo.point + hitInfo.normal * 0.001f, Quaternion.LookRotation(hitInfo.normal));
				hitInfo.collider.GetComponent<EnemyBase>().Hitting(damageValue + Parameters.AddDamage);
			}
			if (hitInfo.collider.tag == "Crate")
			{
				hitInfo.collider.GetComponent<CrateScript>().Hitting(damageValue + Parameters.AddDamage);
			}
		}
	}
}
