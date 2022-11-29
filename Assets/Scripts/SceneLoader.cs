using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
	[SerializeField] private string scene;

	public void LoadScene() {
		SceneManager.LoadScene(scene);
	}

	public void Quit() {
		Application.Quit();
	}
}
