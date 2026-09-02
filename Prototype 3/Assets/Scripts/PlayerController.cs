using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction jumpAction;
    private Rigidbody playerRb;

    public float jumforce = 10;
    public float magnitude = 1;

    private bool isOnGround = true;
    public bool gameOver = false;
    public ParticleSystem explosionParticles;
    public ParticleSystem dirtParticles;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    
    private Animator playerAnimator;
    private AudioSource playerAudio;

    void Start()
    {
        Physics.gravity *= magnitude;

        playerRb = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();  
        
        jumpAction.Enable();
    }

    void Update()
    {
        // if (jumpAction.triggered)
        // {
        //     Debug.Log("SPACE PRESSED | isOnGround = " + isOnGround);
        // }

        if (jumpAction.triggered && isOnGround && !gameOver)
        {
            // Debug.Log("JUMPING");

            playerRb.AddForce(Vector3.up * jumforce, ForceMode.Impulse);

            isOnGround = false;
            dirtParticles.Stop();

            playerAnimator.SetTrigger("Jump_trig");
            playerAudio.PlayOneShot(jumpSound,1.0f);

            // Debug.Log("After jump | isOnGround = " + isOnGround);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Debug.Log("Collision with: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Ground") && !gameOver)
        {
            isOnGround = true;
            dirtParticles.Play();

            // Debug.Log("LANDED | isOnGround = " + isOnGround);
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int",1);
            explosionParticles.Play();
            playerAudio.PlayOneShot(crashSound, 1.0f);
            gameOver = true;
            dirtParticles.Stop();
        }
    }
}