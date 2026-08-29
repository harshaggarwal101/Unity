using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public InputAction moveAction;
    public float moveInput;

    // Start is called before the first frame update
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        moveInput = moveAction.ReadValue<float>();
        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime*speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime*moveInput);
    }
}
