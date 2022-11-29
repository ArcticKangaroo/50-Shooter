using UnityEngine;

public class DestroyAfter : MonoBehaviour {
    [SerializeField] private float destroyAfter;
    void Start() {
        Destroy(gameObject, destroyAfter);
    }
}
