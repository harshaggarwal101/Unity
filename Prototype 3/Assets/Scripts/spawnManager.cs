using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject objectToSpawn;
    private Vector3 spawnPoint=new Vector3(25,0,0);
    private PlayerController PlayerControllerScript;

    private float startDelay = 2;

    private float repeatRate = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnObstacles",startDelay,repeatRate);
        PlayerControllerScript=GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObstacles()
    {
        if (PlayerControllerScript.gameOver == false)
        {
            Instantiate(objectToSpawn, spawnPoint, objectToSpawn.transform.rotation);
        }
    }
}
