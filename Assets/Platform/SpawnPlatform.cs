using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject Platform;
    private GameObject[] clones;
    private float[] allPlatform;
    private float positionPlatformXmin = -1.78f;
    private float positionPlatformXmax = 1.78f;
    private float positionPlatformYmin;
    private float positionPlatformYmax;
    private float lastPlatformX;
    private float lastPlatformY;
    void Start()
    {
        float positionPlatformX = 0;
        float positionPlatformY = -3;
        Vector2 coordinate = new Vector2(positionPlatformX, positionPlatformY);
        Instantiate(Platform, coordinate, Quaternion.identity);
        // Ajoute une plateform en dessous du joueur pour commencer
        lastPlatformX = coordinate.x;
        positionPlatformYmin = -2.5f;
        positionPlatformYmax = -2f;
        SetStartPlatform();
    }

    public void SetStartPlatform()
    {
        float positionPlatformX;
        while (true) {
            positionPlatformX = UnityEngine.Random.Range(positionPlatformXmin, positionPlatformXmax);
            if (positionPlatformX < lastPlatformX + 0.3 && positionPlatformX > lastPlatformX - 0.3)
            {
                continue;
            }
            else
            {
                break;
            }
        }

        float positionPlatformY;
        positionPlatformY = UnityEngine.Random.Range(positionPlatformYmin, positionPlatformYmax);
        Vector2 coordinate = new Vector2(positionPlatformX, positionPlatformY);
        Instantiate(Platform, coordinate, Quaternion.identity);
        lastPlatformX = coordinate.x;
        clones = GameObject.FindGameObjectsWithTag("Platform");
        if (clones.Length < 20)
        {
            positionPlatformYmin = coordinate.y + 0.7f;
            positionPlatformYmax = coordinate.y + 1.4f;
            SetStartPlatform();     
        } else
        {
            return;
        }
    }

    public void AddPlatform(float positionPlatformY)
    {
        float positionPlatformX;
        while (true)
        {
            positionPlatformX = UnityEngine.Random.Range(positionPlatformXmin, positionPlatformXmax);
            if (positionPlatformX < lastPlatformX + 0.3 && positionPlatformX > lastPlatformX - 0.3)
            {
                continue;
            }
            else
            {
                break;
            }
        }
        GameObject lastclones = clones.Last();
        print(lastclones.transform.position.y);
        Vector2 coordinate = new Vector2(positionPlatformX, positionPlatformY);
        Instantiate(Platform, coordinate, Quaternion.identity);
        lastPlatformX = coordinate.x;
        clones = GameObject.FindGameObjectsWithTag("Platform");
    }


    void Update()
    {
        clones = GameObject.FindGameObjectsWithTag("Platform");
        float positionPlatformY;
        while (clones.Length < 20)
        {
            positionPlatformY = 7f;
            AddPlatform(positionPlatformY); 
        }
    }
}
