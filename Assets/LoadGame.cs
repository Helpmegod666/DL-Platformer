using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public int minimumScoreNeeded = 0;
    public string sceneToLoad = "SampleScene";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om det blir en collision på ett objekt med taggen player och points.score är större än minimumscoreneeded kommer poängen resetas och scenen kommer loadas om.
        //Man kan göra så att råttorna har 0 i minimumscoreneeded så den kommer bara loada, och målet för hur många coins det finns.
        if (collision.tag == "Player" && Points.score >= minimumScoreNeeded)
        {
            Points.score = 0;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
