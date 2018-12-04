using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadowVision : MonoBehaviour
{

    //private bool visionActivate = false;

    public GameObject map;

    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.V))
        {
            GetComponent<SpriteRenderer>().enabled = true;


            map.SetActive(false);
            //GameObject[] objects = GameObject.FindGameObjectsWithTag("Hej"):
            //for (int i = 0; i < objects.Length; i++)
            //{

            //}
        }

        else
        {
            map.SetActive(true);
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
