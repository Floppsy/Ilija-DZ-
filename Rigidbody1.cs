using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigidbody1 : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
