using System;
using UnityEngine;

public class pistola : MonoBehaviour
{

   public SpriteRenderer SpriteRenderer;
    [SerializeReference] GameObject bala;
   
    [SerializeReference] Transform objeto;
    public float velocidadeDaBala;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.F) )
        {

            SpriteRenderer.enabled = true;

            Quaternion quaternion = Quaternion.identity;


            GameObject balaprefab = Instantiate(bala, transform.position, quaternion);

            if (!NewMonoBehaviourScript.estaViradoParaDireita) 
            { 
                
                balaprefab.GetComponent<bala>().direçãoDoTiro = -1; 
            
            }
            else 
            {
                balaprefab.GetComponent<bala>().direçãoDoTiro = 1;

            }




                // balaTrandorm.position = new Vector2(velocidadeDaBala * 1, balaTrandorm.position.y);

                SpriteRenderer.enabled = false;

            
        }


    }
}
