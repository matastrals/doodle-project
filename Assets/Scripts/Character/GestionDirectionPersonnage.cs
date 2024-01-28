using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.sprite = Character; 
          
        }
        
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.sprite = CharacterLeft; 
            
        }
    }
}
