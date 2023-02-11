using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Vector2 direccion;

   
    // Update is called once per frame
    void Update()
    {
        direccion = new Vector2( Input.GetAxis("Horizontal"), Input.GetAxis("Vertica
    }
}
