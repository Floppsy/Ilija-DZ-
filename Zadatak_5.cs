using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_5 : MonoBehaviour
{
    // Scejlajte kocku za: a) 0.25 po Y osi svaki frame b) 89 po Z osi pri pokretanju igre c) Kada se odradio b) zadatak neka debug ispiše kolika je trenutna veličina Z osi

    public float sclX;
    public float sclY;
    public float sclZ;
    float rez;

    private void Start()
    {
        transform.localScale += new Vector3(0, 0, 89);

    }
    private void Update()
    {
        transform.localScale += new Vector3(0, 0.25f, 89);
        rez = rez + sclZ;
        Debug.Log(rez);

    }
    
}
