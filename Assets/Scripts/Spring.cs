using UnityEngine;

public class GestionRessort : MonoBehaviour
{
    public Sprite spriteFerme; 
    public Sprite spriteDeploye; 

    private SpriteRenderer spriteRenderer;
    public float forcePropulsion = 10f; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteFerme; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Character"))
        {
            spriteRenderer.sprite = spriteDeploye; 
            PropulserJoueur(other); 
        }
    }

    void PropulserJoueur(Collider2D joueurCollider)
    {
        
        Rigidbody2D joueurRb = joueurCollider.GetComponent<Rigidbody2D>();
        if (joueurRb != null)
        {
            joueurRb.AddForce(Vector2.up * forcePropulsion, ForceMode2D.Impulse);
        }
    }
}
