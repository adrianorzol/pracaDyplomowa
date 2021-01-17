using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wykrywanieWydzialow : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WBiB")
        {

            SceneManager.LoadScene(sceneName: "WBiB");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WBZ")
        {

            SceneManager.LoadScene(sceneName: "WBZ");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WG")
        {

            SceneManager.LoadScene(sceneName: "WG");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WH")
        {

            SceneManager.LoadScene(sceneName: "WH");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WMiI")
        {

            SceneManager.LoadScene(sceneName: "WMiI");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WMW")
        {

            SceneManager.LoadScene(sceneName: "WMW");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WNE")
        {

            SceneManager.LoadScene(sceneName: "WNE");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WNoZ")
        {

            SceneManager.LoadScene(sceneName: "WNoZ");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WNT")
        {

            SceneManager.LoadScene(sceneName: "WNT");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WPiA")
        {

            SceneManager.LoadScene(sceneName: "WPiA");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WRiL")
        {

            SceneManager.LoadScene(sceneName: "WRiL");
            Handheld.Vibrate();
        }

    }
}
