using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gestion : MonoBehaviour
{
    public Sprite Character;
    public Sprite CharacterLeft; 

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Si la touche droite est enfoncée
        if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.sprite = Character;
          
        }
        else if (Input.GetKey(KeyCode.D))
        {
           spriteRenderer.sprite = CharacterLeft; 
            
        }

        if (gameObject.transform.position.y < -5.5f)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
