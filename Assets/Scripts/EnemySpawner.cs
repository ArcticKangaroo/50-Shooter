using System.Collections;
using UnityEngine;

public class EnemySpawner: MonoBehaviour {
	
	[SerializeField] private GameObject enemy;
	
	[SerializeField] private float enemySpawnRate = 4f;
	[SerializeField] private float increaseSpawnRate = 20f;

	[SerializeField] private Transform[] enemySpawnPoints;
	[SerializeField] private ScoreKeeper scoreKeeper;
	
	private float nextSpawnTime;
	private float nextIncreaseSpawnTime;

	private void Start() {
		nextSpawnTime = enemySpawnRate;
		nextIncreaseSpawnTime = increaseSpawnRate;
	}

	private void Update() {
		if (GameObject.FindWithTag("Player")) {
			if (Time.timeSinceLevelLoad > nextSpawnTime) {
				nextSpawnTime = Time.timeSinceLevelLoad + enemySpawnRate;
				StartCoroutine(nameof(SpawnEnemy));
			}
			if(Time.timeSinceLevelLoad > nextIncreaseSpawnTime && enemySpawnRate > 2f) {
				nextIncreaseSpawnTime = Time.timeSinceLevelLoad + increaseSpawnRate;
				enemySpawnRate -= 0.25f;
			}
		}
	}
	
	private IEnumerator SpawnEnemy() {
		float spawnDelay = 1;
		float spawnPointFlashSpeed = 4;

		Transform spawnPoint = enemySpawnPoints[Random.Range(0, enemySpawnPoints.Length)];
		Material spawnPointMaterial = spawnPoint.GetComponent<Renderer>().material;
		Color initialColour = spawnPointMaterial.color;
		Color flashColour = Color.red;
		float spawnFlashTimer = 0;

		while(spawnFlashTimer < spawnDelay) {
			spawnPointMaterial.color = Color.Lerp(initialColour,flashColour, Mathf.PingPong(spawnFlashTimer * spawnPointFlashSpeed, 1));
			spawnFlashTimer += Time.deltaTime;
			yield return null;
		}
		
		GameObject spawnedEnemy = Instantiate(enemy, spawnPoint.position, Quaternion.identity);
		spawnedEnemy.GetComponent<Health>().OnDeath += scoreKeeper.IncreaseScore;
	}
}

