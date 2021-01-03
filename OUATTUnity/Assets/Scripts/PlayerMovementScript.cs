using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private float moveInput;
    public float jumpForce = 10f;

    public bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private Animator anim;

    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * moveInput, rb.velocity.y);

        if(moveInput != 0f)
        {
            anim.SetBool("IsWalking", true);
        } else
        {
            anim.SetBool("IsWalking", false);
        }

        if(moveInput > 0)
        {
            spriteRenderer.flipX = false;
        } else if(moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
    }


}
