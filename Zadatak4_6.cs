using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak4_6 : MonoBehaviour
{
    //Učini da se kocka rotira po svim osima u isto vrijeme na najkraći način.

    private void Update()
    {
        transform.Rotate(new Vector3(1, 1, 1));
    }
}
