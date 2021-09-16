using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
    // Napišite skriptu koja æe uzeti poèetne vrijednosti objekta na sceni (njegov scale)
    // i invertati ga (sve scale vrijednosti postaviti na minus)
public class Zadatak5_4 : MonoBehaviour
{   
    public float sclX;
    public float sclY;
    public float sclZ;

    private void Start()
    {
        sclX = transform.localScale.x;
        sclY = transform.localScale.y;
        sclZ = transform.localScale.z;

        transform.localScale = new Vector3(sclX, sclY, sclZ) * -1;

        //transform.localScale *= -1; --> kraæi zapis invertanja zadanog scale
    }

    
}
