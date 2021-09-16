using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//na klik space upaliti ili ugasiti gravitaciju na objekt
public class Zadatak_2 : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(rb.useGravity == false)
            {
                rb.useGravity = false;
            }
            else if(rb.useGravity == true)
            {
                rb.useGravity = true;
            }
        }
    }
}
