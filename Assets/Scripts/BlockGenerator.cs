using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject enemy;
    
    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Destroyer"))
        {
            enemy.SetActive(true);
            transform.localScale = new Vector3(Random.Range(7f, 10f), transform.localScale.y, transform.localScale.z);
            transform.position = new Vector3(Random.Range(15f, 22f), transform.position.y, transform.position.z);
            if (moveSpeed < 20)
            {
                moveSpeed += 0.4f;
            }
        }
    }
}
