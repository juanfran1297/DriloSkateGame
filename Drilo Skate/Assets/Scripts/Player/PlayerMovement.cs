using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 12.0f;

    private Rigidbody2D rb;
    private Animator miAnim;

    public GameManager gameManager;

    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundedRadius;
    [SerializeField] private bool isGrounded;

    public AudioSource miAudio;


    public float jumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        miAnim = GetComponent<Animator>();
        miAudio = GetComponent<AudioSource>();

        groundCheck = transform.Find("GroundCheck");
        groundedRadius = .1f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (gameManager.pausa)
        {
            return;
        }

            bool inGround = Physics2D.OverlapCircle(groundCheck.position, groundedRadius, whatIsGround);

            if (inGround)
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }

            //Input
            if (Input.GetButtonDown("Fire1"))
            {
                if (!isGrounded)
                {
                    return;
                }
                Jump();
            }
    }

    void FixedUpdate()
    {
        if (gameManager.pausa)
        {
            return;
        }

        rb.velocity = new Vector2(speed, rb.velocity.y);

            miAnim.SetBool("Grounded", isGrounded);

            miAnim.SetFloat("Velocity", rb.velocity.x);
    }

    private void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce));

        if(gameManager.musicOnOff == true)
        {
            miAudio.Play();
        }
    }
}
