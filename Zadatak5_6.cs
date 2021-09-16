using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak5_6 : MonoBehaviour
{
    //Unesite neku javnu vrijednost, napravite for petlju u start metodi koja æe služiti
    //da se u svakom ponavljanju kocka smanji po y i z osi dok god je uvijet zadovoljen, i <= 10

    public float sclX;
    private void Start()
    {
        for(int i = 0; i <= 10; i++)
        {
            transform.localScale -= new Vector3(0, i, i);
        }
    }
}
