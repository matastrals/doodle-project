using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    private GameObject player;
    private GameObject[] clones;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        clones = GameObject.FindGameObjectsWithTag("Platform");      
    }

    void Update()
    {
        if (player.transform.position.y > -1.6f)
        {
            MoveIt();
        }
    }

    void MoveIt()
    {
        foreach (GameObject clone in clones)
        {
            if (clone != null)
            {
                clone.transform.Translate(new Vector2(0, -3) * Time.deltaTime * 0.03f);
                /*player.transform.Translate(new Vector2(0, -3) * Time.deltaTime * 8) ;*/
            }
        }
    }
}
