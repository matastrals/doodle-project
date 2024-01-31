using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IsTouchMonster : MonoBehaviour
{
    private EdgeCollider2D headColl;
    private BoxCollider2D bodyColl;
    private Rigidbody2D playerRb;

    private void Update()
    {
        GameObject monster = GameObject.FindWithTag("Monster");
        if (monster != null)
        {
            headColl = monster.GetComponent<EdgeCollider2D>();
            bodyColl = monster.GetComponent<BoxCollider2D>();
            playerRb = GetComponent<Rigidbody2D>();
        }
        

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == bodyColl)
        {
            SceneManager.LoadScene("GameOver");
        }
        if (other == headColl)
        {
            playerRb.velocity = new Vector2(0, 5);
            Destroy(other.GameObject());
        }
    }
}
