using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour {
	
	private Transform target;
	private NavMeshAgent pathfinder;

	private void Start() {
		pathfinder = GetComponent<NavMeshAgent>();
		pathfinder.speed = Random.Range(5, 11);
		target = GameObject.FindWithTag("Player").transform;
		
		StartCoroutine(UpdatePath());
	}

	private IEnumerator UpdatePath() {
		while(target != null) {
			pathfinder.SetDestination(target.position);
			yield return new WaitForSeconds(0.25f);
		}
	}
}