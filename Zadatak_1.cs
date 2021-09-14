using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_1 : MonoBehaviour
{ 
        //Unesite dvije javne vrijednosti. Neka se objekt na sceni uveća po svim osima u početku za zbroj te dvije javne vrijednosti.

    public float X;
    public float Y;

    float sclX;
    float sclY;
    float sclZ;

    private void Start()
    {   

        var rez = X + Y;            //zbrajanje dviju vrjednosti da bi mogli odrediti za koliko se uvećava objekt 
        sclX = rez;
        sclY = rez;
        sclZ = rez;

        transform.localScale += new Vector3(sclX, sclY, sclZ);
    }


}
