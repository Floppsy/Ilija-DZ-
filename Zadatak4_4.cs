using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak4_4 : MonoBehaviour
{
    // Neka skripta učita sve vrijednosti objekta (sve osi scale, sve osi position, sve osi rotation) i potom radi provjeru,
    // ako je zbroj x y i z (scale posebno, rotation posebno, position posebno) veći od 20 neka se objekt postavi na 0,0,0 sa rotacijama na 0,0,0 i veličinom 1, 1 ,1.
    // U suprotnom neka se pomakne po svim osima za zbroj (početnih osi pozicije), poveća po svim osima za zbroj (za zbroj svih scale osi) i rotira po svim osima na 69, 420, 911.

   public float sclX;
   public float sclY;
   public float sclZ;

   public float rotX;
   public float rotY;
   public float rotZ;

   public float posX;
   public float posY;
   public float posZ;

   float sclRez;
   float rotRez;
   float posRez;

    private void Start()
    {
        sclRez = sclX + sclY + sclZ;
        rotRez = rotX + rotY + rotZ;
        posRez = posX + posY + posZ;

        if(sclRez > 20 && rotRez > 20 && posRez > 20)
        {
            transform.localPosition = new Vector3(0, 0, 0);
            transform.Rotate(new Vector3(0, 0, 0));
            transform.localScale = new Vector3(1, 1, 1);
        }
        
        else if(sclRez <= 20 && rotRez <= 20 && posRez <= 20)
        {
            transform.localPosition += new Vector3(posRez, posRez, posRez);
            transform.localScale += new Vector3(sclRez, sclRez, sclRez);
            transform.Rotate(new Vector3(69, 420, 911));

        }

     } 
    
}
    

   
