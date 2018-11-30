using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public bool isgrounded;
    //Säger att om det finns en collision på något så är isgrounded true.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isgrounded = true;
    }
    //Säger om objektet inte finns någon collision så är isgrounded false.
    private void OnTriggerExit2D(Collider2D Collision)
    {
        isgrounded = false;
    }
}
