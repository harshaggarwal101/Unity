using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction moveAction;
    public InputAction fireAction;
    public float moveSpeed=20;
    public float xRange = 15;
    public GameObject projectilePrefab;
    private float moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
        fireAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<=-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x>=xRange)
        {
            transform.position= new Vector3(xRange,transform.position.y,transform.position.z);
        }

        if (fireAction.triggered)
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
        moveInput=moveAction.ReadValue<float>();
        transform.Translate(Vector3.right*Time.deltaTime*moveSpeed*moveInput);
        
    }
}
