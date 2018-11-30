using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    
    private TextMeshProUGUI text;

    void Start()
    {
        //Componenten textmeshpro hämtas från samma objekt scriptet ligger på.
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        //Efter vi kallade på componenten så säger vi att den ska skriva ut score variablen från scriptet Points.
        text.text = string.Format("Score: {0:0000}", Points.score);
    }
}
