using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wykrywanieWydzialow : MonoBehaviour
{
    private GameObject WBiB, WBZ, WG, WH, WMiI, WMW, WNE, WNoZ, WNT, WPiA, WRiL;
    public Animator animWBiB, animWBZ, animWG, animWH, animWMiI, animWMW, animWNE, animWNoZ, animWNT, animWPiA, animWRiL;
    public float czasAnimacji = 1f;

    private void Awake()
    {
        WBiB = GameObject.FindGameObjectWithTag("WBiB");
        WBZ = GameObject.FindGameObjectWithTag("WBZ");
        WG = GameObject.FindGameObjectWithTag("WG");
        WH = GameObject.FindGameObjectWithTag("WH");
        WMiI = GameObject.FindGameObjectWithTag("WMiI");
        WMW = GameObject.FindGameObjectWithTag("WMW");
        WNE = GameObject.FindGameObjectWithTag("WNE");
        WNoZ = GameObject.FindGameObjectWithTag("WNoZ");
        WNT = GameObject.FindGameObjectWithTag("WNT");
        WPiA = GameObject.FindGameObjectWithTag("WPiA");
        WRiL = GameObject.FindGameObjectWithTag("WRiL");

    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "WBiB")
        {
            
            DontDestroyOnLoad(WBiB);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WBiB", animWBiB));
        }
        if (collision.gameObject.name == "WBZ")
        {
            
            DontDestroyOnLoad(WBZ);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WBZ", animWBZ));
        }
        if (collision.gameObject.name == "WG")
        {
            
            DontDestroyOnLoad(WG);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WG", animWG));
        }
        if (collision.gameObject.name == "WH")
        {
            
            DontDestroyOnLoad(WH);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WH", animWH));
        }
        if (collision.gameObject.name == "WMiI")
        {
            
            DontDestroyOnLoad(WMiI);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WMiI", animWMiI));
        }
        if (collision.gameObject.name == "WMW")
        {
            
            DontDestroyOnLoad(WMW);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WMW", animWMW));
        }
        if (collision.gameObject.name == "WNE")
        {
            
            DontDestroyOnLoad(WNE);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WNE", animWNE));
        }
        if (collision.gameObject.name == "WNoZ")
        {
            
            DontDestroyOnLoad(WNoZ);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WNoZ", animWNoZ));
        }
        if (collision.gameObject.name == "WNT")
        {
            
            DontDestroyOnLoad(WNT);
           
            Handheld.Vibrate();
            StartCoroutine(przejscie("WNT", animWNT));
        }
        if (collision.gameObject.name == "WPiA")
        {
            
            DontDestroyOnLoad(WPiA);
            
            Handheld.Vibrate();
            StartCoroutine(przejscie("WPiA", animWPiA));
        }
        if (collision.gameObject.name == "WRiL")
        {
            
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
