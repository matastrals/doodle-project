using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{
    void Start()
    {
    }

    private void Update()
    {
        Vector2 positionObstacle = transform.position;
        if (positionObstacle.y <= -5)
        {
            Destroy(gameObject);
        }
    }

}
