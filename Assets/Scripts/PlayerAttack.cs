using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour {

	private bool shooting = false;

	[SerializeField] private GameObject bullet;
	[SerializeField] private Transform muzzle;
	[SerializeField] private float fireRate;
	private float shotCounter;
	private AudioSource attackAudio;

	private void Start() {
		attackAudio = GetComponent<AudioSource>();
	}

	private void FixedUpdate() {
		if(shooting) {
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0) {
				Instantiate(bullet, muzzle.position, muzzle.rotation);
				shotCounter = fireRate;
				attackAudio.Play();
			}
		}
	}
	
	public void Fire(InputAction.CallbackContext input) {
		if(input.performed) {
			shooting = true;
		} else if(input.canceled) {
			shooting = false;
		}
	}	
}