using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hPText : MonoBehaviour
{
    private TextMeshProUGUI hText;

    void Start()
    {
        hText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        hText.text = string.Format("Health: {0}", HP.hitPoints);
    }
}
