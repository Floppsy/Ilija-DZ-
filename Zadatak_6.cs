using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_6 : MonoBehaviour
{
    //  Napravite skriptu da se kocka i sfera povećavaju i smanjuju za 3 do maksimalno 25 i minimalno 1 po sve 3 osi. Neka se kocka stalno rotira po javnim vrijednostima po sekundi, kada se kocka smanjuje smjer rotacije se promjeni.

    public float rotX;
    public float rotY;
    public float rotZ;
    public float sclX = 1;
    public float sclY = 1;
    public float sclZ = 1;

    private void Update()

    { 
        transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime);
        if(sclX <= 25 && sclX >= 1)
        {
            transform.localScale += new Vector3(sclX, sclY, sclZ);
        }
        
        
        transform.localScale += new Vector3(-sclX, -sclY, -sclZ);
    }
    

}

