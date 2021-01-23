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
                transform.position = new Vector3(20460.75f, 53759.12f, -9.088684f);
            }
        }
        if(GameObject.Find(name + "mon"))
        {
            if(GameObject.Find("LicznikSzans").GetComponent<licznikOcen>().czyZlapany == true)
                ocena = GameObject.Find("KopiaRzutu").GetComponent<Image>().sprite;

        }
    }
}