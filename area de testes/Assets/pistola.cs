using System;
using UnityEngine;

public class pistola : MonoBehaviour
{

   public SpriteRenderer SpriteRenderer;
    [SerializeReference] GameObject balaObject;
   
    [SerializeReference] Transform objeto;
    public static float velocidadeDaBala;
    public float ateProximoDisparo =0;
    public float tempoDeUmTiroAoutro;
    public int quantidadeDeBalas = 20;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // if (ateProximoDisparo > 0)
        //{

           ateProximoDisparo -= 1;
        //}
        if (Input.GetKey(KeyCode.F) && ateProximoDisparo <= 0  && quantidadeDeBalas>0 )
        {

            SpriteRenderer.enabled = true;

            Quaternion quaternion = Quaternion.identity;

            bala.posiçãoInicialDaBalaX = transform.position.x;
            GameObject balaprefab = Instantiate(balaObject, transform.position, quaternion);

            if (!NewMonoBehaviourScript.estaViradoParaDireita) 
            { 
                
                balaprefab.GetComponent<bala>().direçãoDoTiro = -1; 
            
            }
            else 
            {
                balaprefab.GetComponent<bala>().direçãoDoTiro = 1;

            }




           


            ateProximoDisparo = tempoDeUmTiroAoutro*Time.fixedDeltaTime;

            quantidadeDeBalas -= 1;

            
        }
       




    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            SpriteRenderer.enabled = false;
        }

    }
}
