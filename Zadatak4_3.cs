using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak4_3 : MonoBehaviour
{
    // Unesite jednu javnu vrijednost npr. 15.4f. Ako je ona manja ili jednaka 100 neka se objekt poveća po x osi za vrijednost "javnaVrijednost".
    // JavnaVrijednost se povećava za 1 svaki frame dok god je manja ili jednaka 100, kada javna vrijednost bude veća objekt će stati sa povećavanjem, što znači da se i objekt povećava po svim osima svaki frame za javnaVrijednost.

    public float X = 26.45f; //definiranje javne varijable

    bool stop;

    private void Update()
    { 
        if(X <= 100) //uvjet pod kojim definiramo bool
        {
            stop = true;
        }
       
        else
        {
            stop = false;
        }
        
        if(stop)
        {
            transform.localScale += new Vector3(X, 0, 0); //naredba koja povećava objekt dok je bool true
            X++;
        }

        else if(!stop)
        {
            transform.localScale += new Vector3(0, 0, 0);
        }        
        
      }

}

