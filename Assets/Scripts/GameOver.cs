using System;
using UnityEngine;

public class GameOver : MonoBehaviour {

    [SerializeField] private GameObject gameOverMenu;
    
    private void Start() {
        GameObject.FindWithTag("Player").GetComponent<Health>().OnDeath += DisplayGameOverMenu;
    }

    private void DisplayGameOverMenu() {
        gameOverMenu.SetActive(true);
    }
}
