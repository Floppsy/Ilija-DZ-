using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak4_5 : MonoBehaviour
{
    // Unesite 4 javne vrijednosti (int, int, float, float) Neka se radi provjera svaki frame i dok god je jednadžba istinita neka se objekt povećava za 1 po sekundi(svim osima) i rotira za 2 po sekundi(sve osi).
    // U slučaju kada jednadžba nije istinita neka se objekt smanjuje za 2 po sekundi i rotira za 1 po sekundi(sve osi). Jednadžba: int1* int2 + float1 - float2* int1 >= int1* int2 * float1 / float2


    public int X;
    public int Y;
    public float A;
    public float B;

    bool prov;

    private void Update()
    {
        if(X * Y + A - B * X >= X * Y * A / B)
        {
            prov = true;

        }
        else
        {
            prov = false;
        }

        if(prov)
        {
            transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime;
            transform.Rotate(new Vector3(2, 2, 2) * Time.deltaTime);
        }
        else if(!prov)
        {
            transform.localScale -= new Vector3(2, 2, 2) * Time.deltaTime;
            transform.Rotate(new Vector3(1, 1, 1) * Time.deltaTime);
        }
    }
}
