using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UsuwanieWydzialu : MonoBehaviour
{
    public Sprite ocena;
    
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(name);

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if(GameObject.Find("Zegar" + name))
        {
            if (GameObject.Find("Zegar" + name).GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                switch(name)
                {
                    case "WBiB":
                        {
                            transform.position = new Vector3(20460.75f, 53759.12f, -9.088684f);
                            break;
                        }
                    case "WBZ":
                        {
                            transform.position = new Vector3(20460.22f, 53757.57f, -9.043457f);
                            break;
                        }
                    case "WG":
                        {
                            transform.position = new Vector3(20458.08f, 53760.48f, -9.696777f);
                            break;
                        }
                    case "WH":
                        {
                            transform.position = new Vector3(20456.38f, 53750.05f, -9.696777f);
                            break;
                        }
                    case "WMiI":
                        {
                            transform.position = new Vector3(20455.9f, 53743.55f, -8.429688f);
                            break;
                        }
                    case "WMW":
                        {
                            transform.position = new Vector3(20457.45f, 53749.12f, -12.43292f);
                            break;
                        }
                    case "WNE":
                        {
                            transform.position = new Vector3(20460.67f, 53760.23f, -12.45557f);
                            break;
                        }
                    case "WNoZ":
                        {
                            transform.position = new Vector3(20459.42f, 53760.75f, -12.63323f);
                            break;
                        }
                    case "WNT":
                        {transform.position = new Vector3(20459.88f, 53754.31f, -12.45557f);
                            break;
                        }
                    case "WPiA":
                        {
                            transform.position = new Vector3(20458.27f, 53750.57f, -1.296182f);
                            break;
                        }
                    case "WRiL":
                        {
                            transform.position = new Vector3(20459.63f, 53759.12f, -11.5979f);
                            break;
                        }
                }
               
                    
               
            }
        }
        if(GameObject.Find(name + "mon"))
        {
            if(GameObject.Find("LicznikSzans").GetComponent<licznikOcen>().czyZlapany == true)
                ocena = GameObject.Find("KopiaRzutu").GetComponent<Image>().sprite;

        }
    }
}