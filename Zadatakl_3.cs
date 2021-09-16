using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatakl_3 : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    //kada radimo sa silama koristimo FixedUpdate, a ne obicni Update zbog optimizacije
    private void fixedUpdate()
    {
        rb.AddForce(Vector3.right * speed);             //ovo su sve naèini za upisati kretanje u desno
        //rb.AddForce(new Vector3(1, 0, 0) * speed);
        //rb.AddForce(new Vector3(speed, 0, 0));
        //rb.AddForce(transform.right * speed);
    }
}
