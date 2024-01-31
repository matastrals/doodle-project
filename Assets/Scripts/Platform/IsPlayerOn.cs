using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerOn : MonoBehaviour
{

    public GameObject player;

    void Start()
    {
        EdgeCollider2D ec = GetComponent<EdgeCollider2D>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == player.name && other.gameObject.transform.position.y > this.gameObject.transform.position.y)
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(0f, 5f);
        }
        
    }
}
