using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public int isgrounded;
    //Säger att om det finns en collision på något så är isgrounded true.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isgrounded++;
        }
    }
    //Säger om objektet inte finns någon collision så är isgrounded false.
    private void OnTriggerExit2D(Collider2D Collision)
    {
        if (Collision.tag == "Ground")
        {
            isgrounded--;
        }

        //Fixar buggen när jag använder min shadowVision i en vägg blir det permament 1 efter jag "exitar" en trigger som har taggen ground.
        if (isgrounded <= 1)
        {
            isgrounded = 0;
        }
    }
}
