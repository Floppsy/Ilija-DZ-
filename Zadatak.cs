using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak : MonoBehaviour
{
    //Uèitajte rigidbody bez povlaèenja

    //public Rigidbody rb;

    //private void Update()
    //{
    //    rb.GetComponent<Rigidbody>();

    //}

    //U skripti definirajte janvu varijablu "mass". Rigidbodyu poveæajte težinu NA vrijednost javne varijable

    //public float mass;
    //public Rigidbody rb;

    //private void Start()
    //{
    //    rb.GetComponent<Rigidbody>();
    //    rb.mass = mass;
    //}

    //Rigidboyu na pritisak tipke "K" ukljucite ili iskljucite kinematiku, a na klik g ukljuèite ili iskljuèite gravitaciju

    //public Rigidbody rb;

    //private void Start()
    //{
    //    rb.GetComponent<Rigidbody>();

    //}

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.K))
    //    {
    //        if (rb.isKinematic == true)
    //        {
    //            rb.isKinematic = false;
    //        }
    //        else if (rb.isKinematic == false)
    //        {
    //            rb.isKinematic = true;
    //        }
    //    }
    //    if(Input.GetKeyDown(KeyCode.G))    
    //    {
    //            if(rb.useGravity == true)    
    //            {
    //                rb.useGravity = false;
    //            }
    //            else if(rb.useGravity == false)
    //            {
    //                rb.useGravity = true;
    //            }
    //    }    

    //}

    //U start metodu napravite var vrstu varijable gdje pristupate iskljuèivo gravitaciji rigidbodya te ju iskljuèite

    //public Rigidbody rb;

    //private void Start()
    //{
    //    var XD = rb;   var XD = GetComponent<Rigidbody>().useGravity
    //    if (XD == true)
    //    {
    //        rb.useGravity = false;
    //    }
    //    
    //}

    //Napravite skriptu koja na tipku W udara silom na objekt u smjeru X osi, 
    //na tipku S u negativnom smjeru X osi, na tipku A u pozitivnom smjeru Z osi, a na tipku D u negativnom smjeru Z osi

    public Rigidbody rb;

    private void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    private void Update()
    {   
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.forward);
        }
        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.left);
        }
        if(Input.GetKey(KeyCode.W))
        { 
            rb.AddForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.back);
        }
    }

}
       
        
