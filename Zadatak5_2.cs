using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak5_2 : MonoBehaviour
{
    //Koji tip imaju sljedeæi izrazi (koja je vrsta varijable):
    //
    //a) c + 2.1
    //b) d + c
    //c) 3.14 * d
    //d) i* 3
    //e) c + "2"
    //f) d + c
    //g) "2" * d
    //h) i* "2"

    //a)
    int i;
    string c;
    float d;

    private void Start()
    {
        i = 1;
        c = "Ivan";
        d = 55.5f;
        //a)
        Debug.Log(c + 2.1); //2.1
        //b)
        Debug.Log(d + c); //
        //c)
        Debug.Log(3.14 * d); //
        //d)
        Debug.Log(i * 3); //
        //e)
        Debug.Log(c + "2"); //
        //f)
        Debug.Log(d + c); //
         //g)
         //Debug.Log¸("2" * d); // ERROR cant add int or float to string
        //h)
        // Debug.Log(i * "2"); // ERROR nemožemo množiti int sa stringom
    }
}
