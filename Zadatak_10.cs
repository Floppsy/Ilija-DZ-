using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_10 : MonoBehaviour
    //poveæavanje i smanjivanje kocke
{
    public float sclX;
    public float sclY;
    public float sclZ;

    public bool big = true;
    private void Update()
    {
       if(big)
       {
            transform.localScale += new Vector3(sclX, sclY, sclZ);  
       }
       else if(!big)
       {
            transform.localScale -= new Vector3(sclX, sclY, sclZ);
       }
    }
}
