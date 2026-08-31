using UnityEngine;

public class MoveLeft : MonoBehaviour

{
    private float speed=30;
    private PlayerController playerControllerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime*speed);
        }

        if (gameObject.tag == "Obstacle" && transform.position.x<=0)
        {
            Destroy(gameObject);
        }
    }
}
