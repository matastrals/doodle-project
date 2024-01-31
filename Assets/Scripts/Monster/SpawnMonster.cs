using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public GameObject monster;
    private GameObject isMonster;
    private bool isGameStart = true;
    void Start()
    {
        StartCoroutine(FirstSpawn());
    }

    void SetMonster()
    {
        float coordinateX = UnityEngine.Random.Range(-1.5f, 1.5f);
        float coordianteY = 7f;
        Vector2 coordinate = new Vector2(coordinateX, coordianteY);
        Instantiate(monster, coordinate, Quaternion.identity);
    }

    void Update()
    {
        isMonster = GameObject.FindWithTag("Monster");
        if (!isGameStart && isMonster == null)
        {
            SetMonster();
        }
    }

    IEnumerator FirstSpawn()
    {
        yield return new WaitForSeconds(10);
        SetMonster();
        isMonster = GameObject.FindWithTag("Monster");
        isGameStart = false;
    }

}
