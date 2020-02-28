using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tests : MonoBehaviour
{

    public GameObject objetoAMover;
    public InputField varA;
    public InputField varB;
    public Text trueText;


    private void Start()
    {
        AreaTriangulo(2, 4);
    }

    public void AreaTriangulo(float b, float h)
    {
        float area = (b * h) / 2;
        Debug.Log("El área del triángulo con b=" + b + " y h=" + h + " es igual a " + area);
    }

    public void AreaTrianguloInput()
    {
        float area = (float.Parse(varA.text) * float.Parse(varB.text)) / 2;
        Debug.Log("El área del triángulo con b=" + varA.text + " y h=" + varB.text + " es igual a " + area);
    }


    public void ImprimeNumeros(int numero)
    {
        Debug.Log("Voy a imprimir hasta el numero " + numero);

        for(int i =0; i < numero; i++)
        {
            Debug.Log(i);
        }
    }

    public void MoverObjeto(float distancia)
    {
        Vector3 direccion = new Vector3(distancia,0,0);
        objetoAMover.transform.position += direccion;
    }

    public void SwapText()
    {
        if(trueText.text == "true")
        {
            trueText.text = "false";
        }
        else
        {
            trueText.text = "true";
        }
    }


}
