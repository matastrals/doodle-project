using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float minX = -1.8f;
    private float maxX = 1.8f;
    private float maxY = 3f;
    void Start()
    {

    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveX, 0);
        transform.Translate(movement * Time.deltaTime * 5) ;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y);

    }
}
