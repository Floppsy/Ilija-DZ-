using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_3 : MonoBehaviour
{
    // Napišite skriptu koja će imati Debug.Log() na: a) Awake b) Start c) Update
    public int a;
    private void Awake()
    {
        if (a < 0)
        {
            Debug.Log("Đes baa");
        }


    }
}

