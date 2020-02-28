using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject objetoAMover;

    public void MoverObjeto(float distancia)
    {
        Vector3 direccion = new Vector3(distancia, 0, 0);
        objetoAMover.transform.position += direccion;
    }
}
