using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak5_7 : MonoBehaviour
{
    // Odradite ekvivalentni kod iz zadataka 5 i 6 koristeæi while petlju
    public float sclX;
    public float sclY;
    public float sclZ;
    private void Start()
    {
        while(sclX <= 10)
        { 
            if(sclY < sclZ)
            {
                transform.localScale += new Vector3(sclX, 0, 0);
            }
            else 
            {
                transform.localScale -= new Vector3(0, sclY, sclZ);
            }

            sclX++;
            Debug.Log(sclX);
        
        }
    }
}
