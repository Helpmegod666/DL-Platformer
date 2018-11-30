using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    //En variabel som hämtar värdet från alla coins och inte bara ett
    public static int score; 

    public int amount = 1;

    private float spinSpeed = 180;

    private void Update()
    {
        //Gör så att coinsen roterar runt sin Y axel i verklig tid.
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);  
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om objektet får en collision med ett annat med taggen "Player" så händer If scriptet
        if (collision.tag == "Player") 
        {
            //Värdet på score ökas med amount variabeln som jag har gjort till 1, vi säger också att vi förstör objektet som scriptet ligger på.
            Points.score += amount;
            Destroy(gameObject);
        }
    }
}
