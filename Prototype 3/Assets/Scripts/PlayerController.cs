using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction jumpAction;
    private Rigidbody playerRb;

    public float jumforce = 10;
    public float magnitude = 1;

    private bool isOnGround = true;
    public bool gameOver = false;

    void Start()
    {
        Physics.gravity *= magnitude;

        playerRb = GetComponent<Rigidbody>();

        jumpAction.Enable();
    }

    void Update()
    {
        // if (jumpAction.triggered)
        // {
        //     Debug.Log("SPACE PRESSED | isOnGround = " + isOnGround);
        // }

        if (jumpAction.triggered && isOnGround)
        {
            // Debug.Log("JUMPING");

            playerRb.AddForce(Vector3.up * jumforce, ForceMode.Impulse);

            isOnGround = false;

            // Debug.Log("After jump | isOnGround = " + isOnGround);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Collision with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;

            // Debug.Log("LANDED | isOnGround = " + isOnGround);
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");

            gameOver = true;
        }
    }
}