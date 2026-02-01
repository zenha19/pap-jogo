using System;
using UnityEngine;

public class pistola : MonoBehaviour
{

   public SpriteRenderer SpriteRenderer;
    [SerializeReference] GameObject bala;
    [SerializeReference] Transform objeto;
    
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


            Instantiate(bala, objeto.localPosition, quaternion);

            SpriteRenderer.enabled = false;
        }


    }
}
