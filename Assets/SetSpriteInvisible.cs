using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{
    void Start()
    {
        //Vi säger vid start av spelet att spriterenderen blir avstängd på de spritesen vi inte vill se vid "Gametime". Det gör så de blir osynliga :)
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
