using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
    
    [SerializeField] private float playerSpeed = 8f;

    private Rigidbody playerRB;
    private Vector3 moveVelocity = Vector3.zero;
    private Vector3  lookPoint;
    private Quaternion rotationVelocity = Quaternion.identity;

    private void Start() {
        playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        playerRB.MovePosition(transform.position + moveVelocity * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext input) {
        Vector3 moveInput = new Vector3(input.ReadValue<Vector2>().x, 0, input.ReadValue<Vector2>().y);
        moveVelocity = moveInput.normalized * playerSpeed;
    }

    public void Look(InputAction.CallbackContext input) {
        Ray ray = Camera.main.ScreenPointToRay(input.ReadValue<Vector2>());
        Plane groundPlane = new Plane(Vector3.up, Vector3.up * transform.localScale.y/2);
        float rayDistance;

        if (groundPlane.Raycast(ray,out rayDistance)) {
            Vector3 point = ray.GetPoint(rayDistance);
            Vector3 lookPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(lookPoint);
        }
    }
}