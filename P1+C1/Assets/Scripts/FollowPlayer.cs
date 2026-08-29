using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public float distance = 10f;
    public float height = 5f;

    void LateUpdate()
    {
        // Get the car's position
        Vector3 cameraPos = player.position;

        // Move the camera to the side of the car
        cameraPos += player.right * distance;

        // Move the camera upward
        cameraPos.y += height;

        // Set camera position
        transform.position = cameraPos;

        // Make the camera look at the car
        transform.LookAt(player);
    }
}