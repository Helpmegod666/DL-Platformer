using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public string Scenetoload = "SampleScene";
    public static int hitPoints = 3;
    private int starterHP = 3;
    private float timeElapsed = 0;

    public SpriteRenderer rend;
    public Color ImmunityColor;
    public Color StandardColor;

    private bool immunityFrame = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" && immunityFrame == false)
        {
            hitPoints = hitPoints - 1;

            immunityFrame = true;

            rend.color = ImmunityColor;
        }
    }

    private void Start()
    {
        if (hitPoints < 3)
        {
            hitPoints = 3;
        }
    }

    void Update()
    {
       if (hitPoints <= 0)
       {
            SceneManager.LoadScene(Scenetoload);
            hitPoints = starterHP;
            Points.score = 0;
       }

        if (immunityFrame == true)
        {
            timeElapsed += Time.deltaTime;

            

            if (timeElapsed > 1)
            {
                immunityFrame = false;
                timeElapsed = 0;

                rend.color = StandardColor;
            }
        }
    }
}
