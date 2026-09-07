using UnityEngine;
using UnityEngine.InputSystem;

public class P2 : MonoBehaviour
{
    public InputAction moveAction;
    private float paddleSpeed=10;
    private float yBound=4.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        float moveDir = moveAction.ReadValue<float>();
        if (moveDir > 0 && transform.position.y<yBound)
        {
            transform.Translate(Vector2.up * Time.deltaTime*paddleSpeed);
        }
        else if (moveDir < 0 && transform.position.y>-yBound)
        {
            transform.Translate(Vector2.down * Time.deltaTime*paddleSpeed);
        }
    }
}
