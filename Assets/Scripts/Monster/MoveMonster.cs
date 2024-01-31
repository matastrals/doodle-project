using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMonster : MonoBehaviour
{
    private GameObject player;
    private GameObject monster;
    private float coordinateX;
    private bool whereShouldIGo = true;
    private float speed = 0.2f;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        monster = GameObject.FindWithTag("Monster");
        coordinateX = monster.transform.position.x;
    }

    void Update()
    {
        if (monster != null)
        {
            MoveIt();
            if (player.transform.position.y > -1.6f)
            {
                MoveDown();
            }
        }

    }

    void MoveIt()
    {
        if (monster.transform.position.x != coordinateX - 0.5f && whereShouldIGo)
        {

            monster.transform.Translate(new Vector2(-3, 0) * Time.deltaTime * 0.3f);
            if (monster.transform.position.x < coordinateX - 0.5f)
            {
                whereShouldIGo = false;
            }
        }

        if (monster.transform.position.x != coordinateX + 0.5f && !whereShouldIGo)
        {
            monster.transform.Translate(new Vector2(3, 0) * Time.deltaTime * 0.3f);
            if (monster.transform.position.x > coordinateX + 0.5f)
            {
                whereShouldIGo = true;
            }
        }
    }

    void MoveDown()
    {
        if (monster != null)
        {
            monster.transform.Translate(new Vector2(0, -6) * Time.deltaTime * speed);
        }
    }
}
