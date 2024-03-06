using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public GameObject box;
    private SpriteRenderer boxSprite;
    private SpriteRenderer spriteRenderer;
    float topSide;
    float rightSide;
    void Start()
    {
        boxSprite = box.GetComponent<SpriteRenderer>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        topSide = box.transform.position.y + boxSprite.bounds.size.y / 2;

        rightSide = box.transform.position.x + boxSprite.bounds.size.x / 2f;

        transform.position = new Vector3(rightSide, topSide + 0.8f, transform.position.z);
    }
}
