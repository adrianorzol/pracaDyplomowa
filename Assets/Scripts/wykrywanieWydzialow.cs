using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wykrywanieWydzialow : MonoBehaviour
{
    public GameObject WBiB, WBZ, WG, WH, WMiI, WMW, WNE, WNoZ, WNT, WPiA, WRiL;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WBiB")
        {
            WBiB.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WBiB);
            SceneManager.LoadScene(sceneName: "WBiB");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WBZ")
        {
            WBZ.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WBZ);
            SceneManager.LoadScene(sceneName: "WBZ");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WG")
        {
            WG.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WG);
            SceneManager.LoadScene(sceneName: "WG");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WH")
        {
            WH.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WH);
            SceneManager.LoadScene(sceneName: "WH");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WMiI")
        {
            WMiI.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WMiI);
            SceneManager.LoadScene(sceneName: "WMiI");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WMW")
        {
            WMW.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WMW);
            SceneManager.LoadScene(sceneName: "WMW");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WNE")
        {
            WNE.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WNE);
            SceneManager.LoadScene(sceneName: "WNE");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WNoZ")
        {
            WNoZ.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WNoZ);
            SceneManager.LoadScene(sceneName: "WNoZ");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WNT")
        {
            WNT.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WNT);
            SceneManager.LoadScene(sceneName: "WNT");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WPiA")
        {
            WPiA.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WPiA);
            SceneManager.LoadScene(sceneName: "WPiA");
            Handheld.Vibrate();
        }
        if (collision.gameObject.name == "WRiL")
        {
            WRiL.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WRiL);
            SceneManager.LoadScene(sceneName: "WRiL");
            Handheld.Vibrate();
        }

    }
}
