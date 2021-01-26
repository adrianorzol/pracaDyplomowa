using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObslugaPrzyciskow : MonoBehaviour
{
    public Animator animator;
    public string tekst;
    public GameObject pinezka;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Button>().onClick.AddListener(Klik);
    }

    // Update is called once per frame
    public void Klik()
    {
        if(pinezka)
            pinezka.GetComponent<CanvasGroup>().alpha = 0;
        StartCoroutine(Guzik());
        
    }
    IEnumerator Guzik()
    {
        animator.SetTrigger(tekst);
        yield return new WaitForSeconds(0.5f);
    }
}
