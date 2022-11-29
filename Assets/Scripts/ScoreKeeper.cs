using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	private int score;
	private Text scoreText;

	private void Start() {
		score = 0;
		scoreText = GetComponent<Text>();
	}

	public void IncreaseScore() {
		score += 10;
		scoreText.text = "Score: " + score;
	}
}
