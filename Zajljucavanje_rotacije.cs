using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zajljucavanje_rotacije : MonoBehaviour
{
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;
        

    }
}
