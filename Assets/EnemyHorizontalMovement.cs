using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{

    public float speed = 1f;
    public bool left = true;

    public GroundChecker check;

    private Rigidbody2D rbody;

    void Start()
    {
        //Du kallar för componenten rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
    }
    //Gör en funktion som jobbar i 50 fps istället för update som jobbar så snabbt den kan.
    private void FixedUpdate()
    {
        //Om Boolen Left är sann så ska transformen vara negativ för att göra så Råttan riktas vänster.
        if (left == true)
        {
            //Transform.right är egentligen en vector3 så vi konverterar en vector 3 till vector 2.
            //Hastigheten = "riktning" * Hastigheten på råttan. Den bestämmer riktningen och hur snabb den ska vara.
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        //Annars ska transformen vara positiv för att råttan ska riktas emot höger, som i koordinatsystem.
        else
        {
            //Samma som (Left == True) If funktionen fast gör så den riktas höger med en riktning.
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
    //Om objektet har en trigger och den går in i en annan collider händer funktionen.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om objekten collidar med ett objekt med taggen invisiblewall så blir Left False eller True beroende på vad det var innan den nuddade objektet.
        if (collision.tag == "InvisibleWall")
        {
            left = !left;
        }
    }
}
