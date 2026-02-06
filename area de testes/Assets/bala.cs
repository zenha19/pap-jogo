using UnityEngine;

public class bala : MonoBehaviour
{
    public  int direçãoDoTiro;
    public float velocidadeDaBala;
    public static float posiçãoInicialDaBalaX;
    public Transform posiçãoAtualDaBalaX;
    float distanciaAtravessadaPelaBala;
    public GameObject balabala;



    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distanciaAtravessadaPelaBala = posiçãoInicialDaBalaX - posiçãoAtualDaBalaX.position.x;
        if (distanciaAtravessadaPelaBala>2 || distanciaAtravessadaPelaBala<-2)
        {
            Destroy( balabala );

        }
        transform.Translate(new Vector2(velocidadeDaBala*direçãoDoTiro,0));
    }
}

//Input.GetAxisRaw("Horizontal")