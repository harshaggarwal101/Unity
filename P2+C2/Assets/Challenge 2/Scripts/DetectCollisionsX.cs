using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("BALL COLLIDED WITH: " + other.gameObject.name);
        Destroy(gameObject);
    }
}
