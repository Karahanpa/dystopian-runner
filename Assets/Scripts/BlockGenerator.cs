using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.CompareTag("Destroyer"))
        {
            
            transform.localScale = new Vector3(Random.Range(3f, 9f), transform.localScale.y, transform.localScale.z);
            transform.position = new Vector3(Random.Range(15f, 22f), transform.position.y, transform.position.z);
            if (moveSpeed < 20)
            {
                moveSpeed += 1f;
            }
        }
    }
}
