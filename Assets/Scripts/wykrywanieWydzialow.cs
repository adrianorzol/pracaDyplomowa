using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wykrywanieWydzialow : MonoBehaviour
{
    public GameObject WBiB, WBZ, WG, WH, WMiI, WMW, WNE, WNoZ, WNT, WPiA, WRiL;
    public Animator animWBiB, animWBZ, animWG, animWH, animWMiI, animWMW, animWNE, animWNoZ, animWNT, animWPiA, animWRiL;
    public float czasAnimacji = 1f;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WBiB")
        {
            WBiB.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WBiB);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WBiB", animWBiB));
        }
        if (collision.gameObject.name == "WBZ")
        {
            WBZ.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WBZ);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WBZ", animWBZ));
        }
        if (collision.gameObject.name == "WG")
        {
            WG.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WG);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WG", animWG));
        }
        if (collision.gameObject.name == "WH")
        {
            WH.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WH);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WH", animWH));
        }
        if (collision.gameObject.name == "WMiI")
        {
            WMiI.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WMiI);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WMiI", animWMiI));
        }
        if (collision.gameObject.name == "WMW")
        {
            WMW.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WMW);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WMW", animWMW));
        }
        if (collision.gameObject.name == "WNE")
        {
            WNE.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WNE);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WNE", animWNE));
        }
        if (collision.gameObject.name == "WNoZ")
        {
            WNoZ.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WNoZ);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WNoZ", animWNoZ));
        }
        if (collision.gameObject.name == "WNT")
        {
            WNT.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WNT);
           
            Handheld.Vibrate();
            StartCoroutine(przejscie("WNT", animWNT));
        }
        if (collision.gameObject.name == "WPiA")
        {
            WPiA.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WPiA);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WPiA", animWPiA));
        }
        if (collision.gameObject.name == "WRiL")
        {
            WRiL.transform.position = new Vector3(0f, 0f, 0f);
            DontDestroyOnLoad(WRiL);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WRiL", animWRiL));
        }

    }

    IEnumerator przejscie(string wydzial, Animator animacja)
    {
        animacja.SetTrigger("Start");

        yield return new WaitForSeconds(czasAnimacji);

        SceneManager.LoadScene(sceneName: wydzial);
    }
}
