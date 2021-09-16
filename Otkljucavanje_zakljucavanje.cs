using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otkljucavanje_zakljucavanje : MonoBehaviour
{
    // Skripta za zakljuèavanje rotacije po x osi, te kretanje po x i y osi,
    // te na klik tipke U otkluèajte po svim osima SVE (rotacija i klretanje),
    //a na klik tipke F zalèèjuèajte po svim osima (kretanje)

    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX |
        RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.U))
        {
            rb.constraints = RigidbodyConstraints.None;
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}
