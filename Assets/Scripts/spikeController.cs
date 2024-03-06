using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikeController : MonoBehaviour
{
    public GameObject box;
    private SpriteRenderer boxSprite;
    private SpriteRenderer spriteRenderer;
    float leftSide;

    private void Start()
    {
        boxSprite = box.GetComponent<SpriteRenderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()  
    {
        leftSide = box.transform.position.x - boxSprite.bounds.size.x / 2f;

        transform.position = new Vector3(leftSide - spriteRenderer.bounds.size.x + 0.3f, transform.position.y, transform.position.z);
    }
}
