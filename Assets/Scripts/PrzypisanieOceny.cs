using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrzypisanieOceny : MonoBehaviour
{
    public string wydzial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        if (GameObject.FindGameObjectWithTag(wydzial).GetComponent<Transform>().position == new Vector3(0f, 0f, 0f))
        {
            GetComponent<Image>().sprite = GameObject.FindGameObjectWithTag(wydzial).GetComponent<UsuwanieWydzialu>().ocena;
            GetComponent<CanvasGroup>().alpha = 1;
        }
            
    }
}
