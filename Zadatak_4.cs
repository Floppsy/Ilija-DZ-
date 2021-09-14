using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_4 : MonoBehaviour
{
    // 4.)Rotirajte kocku za 3 stupnja svaku sekundu: a) Po X osi b) po Y osi c) Po X i Y osi D) Kada se rotira po X i Y osi, rotira li se i po Z?
    public float posX = 3;
    public float posY = 3;
    public float posZ;
    public float rotX = 3;
    public float rotY = 3;
    public float rotZ;
    public float sclX = 3;
    public float sclY = 3;
    public float sclZ;

    private void Update()
    {
        transform.localPosition += new Vector3(posX, posY, posZ)* Time.deltaTime;
        transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime);
        transform.localScale += new Vector3(sclX, sclY, sclZ)*Time.deltaTime;
    } 

}
