using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    Material material;
    private float rotationSpeed;
    private float rotationX;
    private float rotationY;
    private float rotationZ;
    void Start()
    {
        material = Renderer.material;
        transform.position = new Vector3(3, 4, 1);
        rotationSpeed = Random.Range(5f, 30f);
        rotationX = Random.Range(-1f, 1f);
        rotationY = Random.Range(-1f, 1f);
        rotationZ = Random.Range(-1f, 1f);
        Invoke("rotationSpeedRandom",3);
        Invoke("changeScale", 1); 
        Invoke("changeColor", 2.0f);
        Invoke("randomAngle",3);
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeed*Time.deltaTime*rotationX,rotationSpeed*Time.deltaTime*rotationY,rotationSpeed*Time.deltaTime*rotationZ);
    }

    void changeColor()
    {
        material.color = Random.ColorHSV();
        float delay = Random.Range(1, 4);
        Invoke("changeColor", delay);
    }

    void changeScale()
    {
        float minScale = 1f;
        float maxScale = 4f;
        transform.localScale = Vector3.one * Random.Range(minScale, maxScale);
        float delay = Random.Range(1, 4);
        Invoke("changeScale", delay);
    }

    void rotationSpeedRandom()
    {
        rotationSpeed = Random.Range(5f, 30f);
        Invoke("rotationSpeedRandom", 3);
    }
    void randomAngle()
    {
        rotationX = Random.Range(-1f, 1f);
        rotationY = Random.Range(-1f, 1f);
        rotationZ = Random.Range(-1f, 1f);
        Invoke("randomAngle",3);
    }
    
}
