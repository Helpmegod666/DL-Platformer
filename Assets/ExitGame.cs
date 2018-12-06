using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Gör så att du exitar spelet, när man trycker på play blir "isplaying" true fast denna tvingar den till false, AKA slutar spelet.
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
