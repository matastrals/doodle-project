using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject Platform;
    private GameObject[] clones;
    private float positionPlatformXmin = -1.78f;
    private float positionPlatformXmax = 1.78f;
    private float positionPlatformYmin;
    private float positionPlatformYmax;
    private float lastPlatformX;
    private float lastPlatformY;
    private int numberOfPlatform = 15;
    void Start()
    {
        CreateFirstPlatform();
    }

    public void CreateFirstPlatform()
    {
        float positionPlatformX = 0;
        float positionPlatformY = -3;
        Vector2 coordinate = new Vector2(positionPlatformX, positionPlatformY);
        Instantiate(Platform, coordinate, Quaternion.identity);
        lastPlatformX = coordinate.x;
    }

    public void AddPlatform(float lastPlatformY)
    {
        float positionPlatformX;
        float positionPlatformY;
        while (true)
        {
            positionPlatformX = UnityEngine.Random.Range(positionPlatformXmin, positionPlatformXmax);
            if (positionPlatformX < lastPlatformX + 0.5 && positionPlatformX > lastPlatformX - 0.5)
            {
                continue;
            }
            else
            {
                break;
            }
        }
        positionPlatformYmin = lastPlatformY + 0.1f;
        positionPlatformYmax = positionPlatformYmin + 0.4f;
        positionPlatformY = UnityEngine.Random.Range(positionPlatformYmin, positionPlatformYmax);
        Vector2 coordinate = new Vector2(positionPlatformX, positionPlatformY);
        Instantiate(Platform, coordinate, Quaternion.identity);
        lastPlatformX = coordinate.x;
        clones = GameObject.FindGameObjectsWithTag("Platform");
    }


    void Update()
    {
        clones = GameObject.FindGameObjectsWithTag("Platform");
        if (clones.Length < numberOfPlatform)
        {
            lastPlatformY = clones.Last().transform.position.y;
            if (lastPlatformY > 6.8)
            {
                lastPlatformY = 5.8f;
            }
            AddPlatform(lastPlatformY);
        }
    }
}
