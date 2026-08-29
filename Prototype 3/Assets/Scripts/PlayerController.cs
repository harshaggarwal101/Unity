using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction jumpAction;
    private Rigidbody playerRb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        jumpAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered)
        {
            playerRb.AddForce(Vector3.up * 50,ForceMode.Impulse);
        }
    }
}
