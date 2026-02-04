using UnityEngine;

public class bala : MonoBehaviour
{
    public  int direçãoDoTiro;
    public float velocidadeDaBala;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(velocidadeDaBala*direçãoDoTiro,0));
    }
}

//Input.GetAxisRaw("Horizontal")