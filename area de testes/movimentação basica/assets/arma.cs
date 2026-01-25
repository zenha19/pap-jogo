using UnityEngine;

public class arma : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider2D;
    public static int dano =5;

    void Start()
    {
       spriteRenderer.enabled = false;
        boxCollider2D.enabled = false;
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H)) 
        {
            spriteRenderer.enabled = true;
            boxCollider2D.enabled = true;
            
        }
        else 
        {
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;

        }
        
    }
}
