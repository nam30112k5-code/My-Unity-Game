using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private LayerMask groundPlayer;
    [SerializeField] private Transform groundCheck;
    private Gamemanager gamemanager;
    private bool isGrounded;
    private Animator animator;

    private Rigidbody2D rb;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        gamemanager=FindAnyObjectByType<Gamemanager>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {  if (gamemanager.IsgameOver())
            return;
        HandleMovement();
        HandleJump();
        Animation();
    }
    private void HandleMovement()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        if (moveInput > 0) transform.localScale = new Vector3Int(1, 1, 1);
        else if (moveInput < 0) transform.localScale = new Vector3Int(-1, 1, 1);
    }
    private void HandleJump()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundPlayer);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        }
    }
    private void Animation()
    {
        bool isRuning = Mathf.Abs(rb.velocity.x) > 0.1f;
        bool isJump = !isGrounded;
        animator.SetBool("IsRuning", isRuning);
        animator.SetBool("IsJump", isJump);
    }
}
