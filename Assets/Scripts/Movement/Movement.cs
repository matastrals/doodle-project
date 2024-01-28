using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forceSaut = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);

        transform.Translate(movement * Time.deltaTime * 5);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * forceSaut;
        }
    }
}
