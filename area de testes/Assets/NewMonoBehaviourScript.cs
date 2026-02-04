using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public static int moedas =0;

    public float velocidadeDoJogador;

    public Rigidbody2D origidBody2d;

    public float alturaDoPulo;

    public bool estaNoChao =false;

    [SerializeField] Transform arma;

    [SerializeField] Transform pistola;

    public static bool estaViradoParaDireita;


    Vector2 direita = new (0.1f, 0f);
    Vector2 esquerda = new (-0.1f, 0f);


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground")) 
        { 
            
            estaNoChao = true;
           
        }
        
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {

            estaNoChao = false;

            
        }
       
    }

    public void Virar()
    {
        


        float direcao = Input.GetAxisRaw("Horizontal");

        if (direcao > 0)
        {
            arma.localPosition = direita;
            pistola.localPosition = direita;
            estaViradoParaDireita = true;
           

        }
        else if (direcao < 0) 
        {
            arma.localPosition = esquerda;
            pistola.localPosition = esquerda;
            estaViradoParaDireita=false;
            
        }

    }


    // Update is called once per frame


    void Update()
     {
        float inputDoMovimento =Input.GetAxisRaw("Horizontal");
        origidBody2d.linearVelocity= new Vector2(inputDoMovimento * velocidadeDoJogador, origidBody2d.linearVelocity.y);
        Virar();

        if (estaNoChao ==true)
        {
            float inputVerticalDoMovimento = Input.GetAxisRaw("Jump");
            origidBody2d.linearVelocity = new Vector2(origidBody2d.linearVelocity.x, inputVerticalDoMovimento * alturaDoPulo);


        }

    }

}
