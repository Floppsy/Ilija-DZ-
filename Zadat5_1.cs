using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadat5_1 : MonoBehaviour
{   //a) 2 + 8 * 3
    //b) 8 * (3 + 2) 
    //c) 8 / 3 + 2
    //d) 8 % 3 + 2
    //e) 31 % 4 + 9 * 2
    //f) 9 * (2) + 2
    //g) 9 / ( 4 >= 2 + 2)
    //h) 9 * !3 + 2
    private void Start()
    {   //a)
        Debug.Log(2 + 8 * 3); //26
        //b)
        Debug.Log(8 * (3 + 2)); //40
        //c)
        Debug.Log(8 / 3 + 2); //4
        //d
        Debug.Log(8 % 3 + 2); //4
        //e
        Debug.Log(31 % 4 + 9 * 2); //21
        //f
        Debug.Log(9 * (2) + 2); //20
        //g
       // Debug.Log(9 / (4 >= 2 + 2)); // Compile error -> int with bool
        //h
       // Debug.Log(9 * !3 + 2); // Compile error ! cant be used with int

    }
}
