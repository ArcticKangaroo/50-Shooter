using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {
    
    [SerializeField] private float health;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private GameObject deathEffect;
    [SerializeField] private float deathEffectTime;

    public event System.Action OnDeath;
    
    private void Start() {
	    healthSlider.maxValue = health;
	    healthSlider.value = healthSlider.maxValue;
    }
    
    public void TakeDamage(float damage) {
	    if (!healthSlider.gameObject.activeSelf) healthSlider.gameObject.SetActive(true);
	    health -= damage;
	    healthSlider.value = health;
	    if(health <= 0) {
		    Die();
	    }
    }

    public void Die() {
	    GameObject deathSystem = Instantiate(deathEffect, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), Quaternion.identity);
	    Destroy(deathSystem, deathEffectTime);
	    
	    if (OnDeath != null) {
		    OnDeath();
	    }
	    Destroy(gameObject);
    }
}
