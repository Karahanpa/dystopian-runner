using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public bool isGrounded = true;


    public GameObject projectilePrefab;
    public InputAction launchAction;
    public InputAction jumpAction;

    Rigidbody2D rigidbody2d;
    Animator animator;

    void Start()
    {
        launchAction.Enable();
        jumpAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = rigidbody2d.GetComponent<Animator>();

        jumpAction.started += ctx => Jump();
    }

    private void Update()
    {
        animator.SetBool("isGrounded", isGrounded);

        if (isGrounded)
        {
            jumpAction.Enable();
        } else
        {
            jumpAction.Disable();
        }
    }

    private void Jump()
    {
        rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jumpForce);
        animator.SetTrigger("jump");
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

}
