using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Area : MonoBehaviour
{
    public InputField varA;
    public InputField varB;
    public Text resultado;

    public void AreaTrianguloInput()
    {
        float area = (float.Parse(varA.text) * float.Parse(varB.text)) / 2;
        Debug.Log("El área del triángulo con b=" + varA.text + " y h=" + varB.text + " es igual a " + area);
        resultado.text = "El área del triángulo con b=" + varA.text + " y h=" + varB.text + " es igual a " + area;
    }
}
