using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax2 : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public float parallaxSpeed;

    float spriteWidth;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteWidth = spriteRenderer.bounds.size.x;
    }


    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.deltaTime * parallaxSpeed);


        if (transform.position.x < -spriteWidth)
        {
            transform.position = new Vector3(transform.position.x + spriteWidth * 3, transform.position.y, transform.position.z);
        }

    }
}
