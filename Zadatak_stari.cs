using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadatak_stari : MonoBehaviour
{
    //igrac ima 100 HP. Ako mu HP padne ispod 75 regenrira mu se health za 10, a ako padne ispod 25 i igrac ostane ziv, regenerira mu se za 25 HP.
    //Igrac prvo primi dmg od 55, a zatim opet primi dmg od 55. Koliko hp ima igrac?


    int hp = 100;
    private void Start()
    {
        

        if (hp < 75 && hp >= 25)
        { 
	        hp += 10;  
        }

        else if (hp < 25 && hp > 0) 
        {
             hp += 25;
        }

        hp -= 55;   //45
                    //+10=55
        hp -= 55;   //0

        Debug.Log(hp + " Krepo "); // Krepo
    }  
   
    
}
