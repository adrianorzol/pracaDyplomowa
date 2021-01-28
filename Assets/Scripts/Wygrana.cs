using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wygrana : MonoBehaviour
{
    public GameObject WBiB, WBZ, WG, WH, WMiI, WMW, WNE, WNoZ, WNT, WPiA, WRiL;
    //public GameObject[] wydzialy;
    public int licznik = 0;
    public GameObject muzyka;
    // Start is called before the first frame update
    void Start()
    {
        

    }
    private void Awake()
    {
        
        
        
    }
    // Update is called once per frame
    void Update()
    {
        //if(GameObject.Find("Muzyka"))
        if (WBiB.GetComponent<CanvasGroup>().alpha == 1 && WBZ.GetComponent<CanvasGroup>().alpha == 1 && WG.GetComponent<CanvasGroup>().alpha == 1 &&
            WH.GetComponent<CanvasGroup>().alpha == 1 && WMiI.GetComponent<CanvasGroup>().alpha == 1 && WMW.GetComponent<CanvasGroup>().alpha == 1 &&
            WNE.GetComponent<CanvasGroup>().alpha == 1 && WNoZ.GetComponent<CanvasGroup>().alpha == 1 && WNT.GetComponent<CanvasGroup>().alpha == 1 &&
            WNoZ.GetComponent<CanvasGroup>().alpha == 1 && WPiA.GetComponent<CanvasGroup>().alpha == 1 && licznik != 2)
            licznik = 1;
        if (licznik == 1)
        {
            StartCoroutine(wygrana());
            
        }
    }

    IEnumerator wygrana()
    {
        licznik = 2;
        yield return new WaitForSeconds(1f);
        muzyka.SetActive(false);
       
       
       
        gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.95f);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(0.95f);
        GetComponent<AudioSource>().Play();
    }
    public void znikanie()
    {
        transform.localScale = new Vector3(0f, 0f, 0f);
        muzyka.SetActive(true);
    }
}
