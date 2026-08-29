using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperBound = 25;
    private float lowerBound = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= upperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z <= lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
