using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public float velocidadeDoJogador;

    public Rigidbody2D origidBody2d;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }
     void FixedUpdate()
     {
        float inputDoMovimento =Input.GetAxisRaw("Horizontal");
        origidBody2d.linearVelocity= new Vector2(inputDoMovimento * velocidadeDoJogador, origidBody2d.linearVelocity.y);
       
     }

}
