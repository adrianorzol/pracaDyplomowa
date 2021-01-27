using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrzypisanieOceny : MonoBehaviour
{
    public string wydzial;
    public Sprite trzy;
    public Sprite trzyPol;
    public Sprite cztery;
    public Sprite czteryPol;
    public Sprite piec;
    // Start is called before the first frame update
    void Update()
    {
        if (GameObject.FindGameObjectWithTag(wydzial).GetComponent<Transform>().position == new Vector3(0f, 0f, 0f))
        {
           
            switch(GameObject.FindGameObjectWithTag(wydzial).GetComponent<UsuwanieWydzialu>().ocena)
            {
                case "ocena_1":
                    {
                        GetComponent<Image>().sprite = trzy;
                        break;
                    }
                case "ocena_2":
                    {
                        GetComponent<Image>().sprite = trzyPol;
                        break;
                    }
                case "ocena_3":
                    {
                        GetComponent<Image>().sprite = cztery;
                        break;
                    }
                case "ocena_4":
                    {
                        GetComponent<Image>().sprite = czteryPol;
                        break;
                    }
                case "ocena_5":
                    {
                        GetComponent<Image>().sprite = piec;
                        break;
                    }
            }
            GetComponent<CanvasGroup>().alpha = 1;
        }
    }

    // Update is called once per frame
    void Awake()
    {
        
            
    }
}
