using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowVision : MonoBehaviour
{
    //man gör en variabel där man kan lägga in ett objekt för att kunna ändra det med scripts. samma sak som spriterenderer. I detta fallet sätter man av och på på en tilemap.
    public GameObject map;

    void Start()
    {
        //man får en component på spritrenderen för objekt som scriptet ligger på.
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
    void Update()
    {
        //Om man håller ner V kommer spriterenderen på objektet aktiveras och kommer objektet som är tillagt bli "deactivated"
        if (Input.GetKey(KeyCode.V))
        {
            GetComponent<SpriteRenderer>().enabled = true;

            map.SetActive(false);
        }
        // annars om man inte håller ner V kommer tilemapen vara aktiverad och kommer spriterenderen vara avaktiverad.
        else
        {
            map.SetActive(true);
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
