using UnityEngine;

public class Explosion : MonoBehaviour {
	
	[SerializeField] private float damage;
	
	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<Health>().TakeDamage(damage);
		}
	}
}
