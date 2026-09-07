using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D ballRb;

    [SerializeField] private float ballSpeed = 5f;

    void Start()
    {
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        ballRb.linearVelocity = randomDirection * ballSpeed;

        InvokeRepeating(nameof(updateBallSpeed), 5f, 5f);
    }

    void updateBallSpeed()
    {
        ballSpeed += 1f;
        ballRb.linearVelocity = ballRb.linearVelocity.normalized * ballSpeed;
    }
}