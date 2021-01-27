using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UsuwanieWydzialu : MonoBehaviour
{
    public string ocena;
    private void Start()
    {
        Progres data = SystemZapisywania.WczytaniePostepu();
        
        Vector3 position;
        if(data != null)
        {
            switch (name)
            {
                case "WBiB":
                    {
                        position.x = data.WBiB[0];
                        position.y = data.WBiB[1];
                        position.z = data.WBiB[2];
                        transform.position = position;
                        ocena = data.ocenaWBiB;
                        break;
                    }
                case "WBZ":
                    {
                        position.x = data.WBZ[0];
                        position.y = data.WBZ[1];
                        position.z = data.WBZ[2];
                        transform.position = position;
                        ocena = data.ocenaWBZ;
                        break;
                    }
                case "WG":
                    {
                        position.x = data.WG[0];
                        position.y = data.WG[1];
                        position.z = data.WG[2];
                        transform.position = position;
                        ocena = data.ocenaWG;
                        break;
                    }
                case "WH":
                    {
                        position.x = data.WH[0];
                        position.y = data.WH[1];
                        position.z = data.WH[2];
                        transform.position = position;
                        ocena = data.ocenaWH;
                        break;
                    }
                case "WMiI":
                    {
                        position.x = data.WMiI[0];
                        position.y = data.WMiI[1];
                        position.z = data.WMiI[2];
                        transform.position = position;
                        ocena = data.ocenaWMiI;
                        break;
                    }
                case "WMW":
                    {
                        position.x = data.WMW[0];
                        position.y = data.WMW[1];
                        position.z = data.WMW[2];
                        transform.position = position;
                        ocena = data.ocenaWMW;
                        break;
                    }
                case "WNE":
                    {
                        position.x = data.WNE[0];
                        position.y = data.WNE[1];
                        position.z = data.WNE[2];
                        transform.position = position;
                        ocena = data.ocenaWNE;
                        break;
                    }
                case "WNoZ":
                    {
                        position.x = data.WNoZ[0];
                        position.y = data.WNoZ[1];
                        position.z = data.WNoZ[2];
                        transform.position = position;
                        ocena = data.ocenaWNoZ;
                        break;
                    }
                case "WNT":
                    {
                        position.x = data.WNT[0];
                        position.y = data.WNT[1];
                        position.z = data.WNT[2];
                        transform.position = position;
                        ocena = data.ocenaWNT;
                        break;
                    }
                case "WPiA":
                    {
                        position.x = data.WPiA[0];
                        position.y = data.WPiA[1];
                        position.z = data.WPiA[2];
                        transform.position = position;
                        ocena = data.ocenaWPiA;
                        break;
                    }
                case "WRiL":
                    {
                        position.x = data.WRiL[0];
                        position.y = data.WRiL[1];
                        position.z = data.WRiL[2];
                        transform.position = position;
                        ocena = data.ocenaWRiL;
                        break;
                    }
            }
        }
        

    }
    

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
                ocena = GameObject.Find("KopiaRzutu").GetComponent<Image>().sprite.name;


        }
    }
}