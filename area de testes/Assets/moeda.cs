using UnityEngine;
using TMPro;

public class moeda : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("personagem")) 
        {
            NewMonoBehaviourScript.moedas += 1;

            Debug.Log(NewMonoBehaviourScript.moedas);

            atualizarMoedas.AtualizarCoins();

           

            Destroy(gameObject);


        }
       
    }

    // Update is called once per frame
   
}
