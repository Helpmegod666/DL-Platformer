using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public string Scenetoload = "SampleScene";
    //gör så att variabeln gäller överallt.
    public static int hitPoints = 3;
    private int starterHP = 3;
    private float timeElapsed = 0;

    // Spriterenderer gör så att man renda en färg, color variablerna är de färgerna som jag shiftar emellan.
    public SpriteRenderer rend;
    public Color ImmunityColor;
    public Color StandardColor;

    private bool immunityFrame = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //när man nuddar en fiende och immunityframe är falsk så kommer en av dina hitpoints tas bort och immunityframes blir True.
        if (collision.tag == "Enemy" && immunityFrame == false)
        {
            hitPoints = hitPoints - 1;

            immunityFrame = true;

            //färgen man får medans immunity frames är aktiva.
            rend.color = ImmunityColor;
        }
    }

    private void Start()
    {
        //om dina hitpoints är mindre än ditt starterhp vid start av spelet kommer dina hitpoints bli ditt starterhp igen.
        if (hitPoints < starterHP)
        {
            hitPoints = starterHP;
        }
    }

    void Update()
    {
        //när dina hitpoints når 0 så kommer scenen som är en variabel i detta fallet bli laddat. ditt hp kommer också bli ditt starter hp.
       if (hitPoints <= 0)
       {
            SceneManager.LoadScene(Scenetoload);
            hitPoints = starterHP;
            Points.score = 0;
       }
       //om immunity frames är true kommer en timer sättas på.
        if (immunityFrame == true)
        {
            timeElapsed += Time.deltaTime;

            
            //när timern är mer än 1 kommer immunityframes bli false och timer resetas.
            if (timeElapsed > 1)
            {
                immunityFrame = false;
                timeElapsed = 0;
                //färgen för när man inte har någon immunityframe på.
                rend.color = StandardColor;
            }
        }
    }
}
