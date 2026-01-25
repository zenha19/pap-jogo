using UnityEngine;

public class moeda : MonoBehaviour
{
    public BoxCollider2D boxCollider2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("personagem")) 
        {
            NewMonoBehaviourScript.moedas += 1;

            Debug.Log(NewMonoBehaviourScript.moedas);

            gameObject.SetActive(false);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
