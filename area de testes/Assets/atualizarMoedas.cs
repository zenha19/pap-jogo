using System;
using TMPro;
using UnityEngine;

public class atualizarMoedas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public  TextMeshProUGUI text;

    public static TextMeshProUGUI text1;

    
    private void Start()
    {
        string texto = Convert.ToString(NewMonoBehaviourScript.moedas);

        text.text = texto;

        text1 = text;
    }
    public static void AtualizarCoins ()
    {
        string texto = Convert.ToString(NewMonoBehaviourScript.moedas);

        text1.text = texto;

    }
}
