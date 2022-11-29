using UnityEngine;

public class EnemyAttack : MonoBehaviour {
	
	[SerializeField] private GameObject explosion;
	
	private void OnCollisionEnter(Collision other) {
		if(other.gameObject.tag == "Player") {
			Instantiate(explosion, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), Quaternion.identity);
			Destroy(gameObject);
		}
	}
}