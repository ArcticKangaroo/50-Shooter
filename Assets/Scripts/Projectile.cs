using UnityEngine;

public class Projectile : MonoBehaviour {
	
	[SerializeField] private float speed = 50f;
	
	private void Update() {
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<Health>().TakeDamage(1);
			Destroy(gameObject);
		} else if(other.gameObject.tag == "Obstacle") {
			Destroy(gameObject);
		}
	}
}
