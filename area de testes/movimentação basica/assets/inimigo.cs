using UnityEngine;

[RequireComponent(typeof(inimigo))]
public class inimigo : MonoBehaviour
{
    public int vida=100;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider2D;
    [SerializeReference] GameObject moeda;
    [SerializeReference] Transform objeto;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame

        

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("arma"))
        {
            vida -= arma.dano;
            Debug.Log("sua arma me tocou seu safado");

        }
         Debug.Log(vida);
        if (vida <= 0) 
        {
            
            Quaternion quaternion = Quaternion.identity;

            
            Instantiate(moeda, objeto.localPosition, quaternion);
            



            GetComponent<inimigo>().enabled = false;
            gameObject.SetActive(false);
        }
    }
}
