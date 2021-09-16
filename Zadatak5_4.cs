using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
    // Napi�ite skriptu koja �e uzeti po�etne vrijednosti objekta na sceni (njegov scale)
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

        //transform.localScale *= -1; --> kra�i zapis invertanja zadanog scale
    }

    
}
