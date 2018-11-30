using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public float moveSpeed = 6f;
    public float jumpSpeed = 1f;

    public GroundChecker groundCheck;

    private Rigidbody2D rbody;

    void Start()
    {
        //Kallar på componenten rigidbody2D som ligger på objektet.
        rbody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //Gör så att rbodyns velocity är = vector2(input.getaxis(horizontal)) som redan har A och D för att röra på sig,
        //sedan multiplicerar vi detta med våran movespeed som vi vill ha, och så behåller vi velocity.y som den är.
        rbody.velocity = new Vector2(
            Input.GetAxis("Horizontal") * moveSpeed,
            rbody.velocity.y);
        //Om man trycker på knappen som är associerad med "Jump" så kommer funktionen hända. "Jump" är egentligen Space.
        if (Input.GetButtonDown("Jump"))
        {
            //Om groundchecken är true så kommer funktionen hända.
            if(groundCheck.isgrounded == true)
            { 
                //Rbodyns velocity ändras fast velocityn på x kommer behållas, fast på y kommer våran jumpspeed variabel göra så vi "hoppar"
            rbody.velocity = new Vector2(
                rbody.velocity.x,
                jumpSpeed);
            }
        }
    }
}
