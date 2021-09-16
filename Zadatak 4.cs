using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak4 : MonoBehaviour
{
    //Poveæajte kocku za 0.1 svaki frame
    private void Update()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
