using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hPText : MonoBehaviour
{
    private TextMeshProUGUI hText;
    // hämtar componeten textmesh pro
    void Start()
    {
        hText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Jag gör så att textmeshpro skriver detta.
        hText.text = string.Format("Health: {0}", HP.hitPoints);
    }
}
