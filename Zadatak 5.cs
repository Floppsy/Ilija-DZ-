using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak5 : MonoBehaviour
{
    //Poveæajte kocku za javne vrijednosti za sve tri osi i poveæavajte ju za te vrijednosti po osima svaku sekundu
    public float xscale, yScale, zScale;

    private void Update()
    {
        transform.localScale += new Vector3(xscale, yScale, zScale);
    }
}
