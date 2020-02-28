using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    public void ImprimeNumeros(int numero)
    {
        Debug.Log("Voy a imprimir hasta el numero " + numero);

        for (int i = 0; i < numero; i++)
        {
            Debug.Log(i);
        }
    }
}
