using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak5_5 : MonoBehaviour
{
    // Unesite neku javnu vrijednost,
    // napravite for petlju u start metodi koja �e slu�iti da se u svakom ponavljanju kocka pove�a po x osi za vrijednost i,
    // dok god je uvijet zadovoljen, i < javna vrijednost

    public float sclX;
    private void Start()
    {
        for (int i = 0; i < sclX; i++)
        {
            transform.localScale += new Vector3(i, 0, 0);
        }
    }
}
