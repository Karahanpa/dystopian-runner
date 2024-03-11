using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    // public float bulletSpeed = 10f;
    private bool isGrounded = true;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;

    // public GameObject projectilePrefab;
    // public InputAction launchAction;
    public InputAction jumpAction;
    public InputAction slashAction;

    Rigidbody2D rigidbody2d;
    Animator animator;

    void Start()
    {
        // launchAction.Enable();
        jumpAction.Enable();
        slashAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = rigidbody2d.GetComponent<Animator>();

        jumpAction.started += ctx => Jump();
        // launchAction.started += ctx => LaunchProjectile();
        slashAction.started += ctx => Slash();
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

    private void Slash()
    {
        animator.SetTrigger("attack");

        Collider2D[] hitEnemy = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach(Collider2D enemy in hitEnemy)
        {
            Debug.Log("you hit " + enemy.name);
            enemy.gameObject.SetActive(false);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null) return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Destroyer"))
        {
            GameManager.instance.Death();
        } else if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager.instance.Death();
        }
    }
    
    //private void LaunchProjectile()
    //{
    //    Vector3 spawnPoint = new Vector3 (transform.position.x + 0.6f, transform.position.y, transform.position.z);

    //    GameObject bullet = Instantiate(projectilePrefab, spawnPoint, Quaternion.identity);

    //    Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

    //    if(bulletRb != null)
    //    {
    //        bulletRb.velocity = transform.right * bulletSpeed;
    //    }
    //}
}
