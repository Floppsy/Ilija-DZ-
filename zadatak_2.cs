using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_2 : MonoBehaviour
{
    // Unesite dvije javne vrijednosti (float i int) ako je njihov zbroj veći od 20 neka se sve osi povećaju za 20, a ako je njihov zbroj manji ili jednak od 20 neka se objekt po svim osima smanji za zbrojenu vrijednost.

    public float X;
    public int Y;
    float rez;

    private void Start()
    {
        rez = X + Y;            //zbroj javnih vrijednosti potreban za određivanje uvjeta

        if(rez > 20)            //uvjet u slučaju da je zbroj javnih vrijednosti veći od 20
        {
            transform.localScale += new Vector3(20, 20, 20);
        }

        else if(rez <= 20)      //uvjet da je zbroj javnih vrijednosti manje ili jednak 20
        {
            transform.localScale -= new Vector3(20, 20, 20);
        }
        
    }


}
