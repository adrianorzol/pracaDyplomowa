using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZatrzymanieLosowania : MonoBehaviour
{
    public Button przycisk;
    public Animator animacja;
    void Start()
    {
        przycisk.onClick.AddListener(Klik);
    }
    // Start is called before the first frame update
    void Klik()
    {
        StartCoroutine(Kopia());
    }

    IEnumerator Kopia()
    {
        GetComponent<Image>().sprite = GameObject.Find("LosowanieOcen").GetComponent<Image>().sprite;
        GetComponent<CanvasGroup>().alpha = 1;
        animacja.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        if (GameObject.Find("LicznikSzans").GetComponent<lapanie>().czyZlapany == true)
            yield return new WaitForSeconds(0.5f);
        animacja.SetTrigger("Stop");
        GetComponent<CanvasGroup>().alpha = 0;
    }
}
