using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class lapanie : MonoBehaviour
{
    public bool czyZlapany = new bool();
    public Button przycisk;
    void Start()
    {
        przycisk.onClick.AddListener(delegate { Klik(przycisk); });
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Klik(Button przycisk)
    {
        int number;
        
        switch (przycisk.image.sprite.name)
        {
            case "ocena_0":
                czyZlapany = false;
                break;
            case "ocena_1":
                number = Random.Range(0, 5);
                if (number >= 4)
                    czyZlapany = true;
                else
                    czyZlapany = false;
                break;
            case "ocena_2":
                number = Random.Range(0, 5);
                if (number >= 3)
                    czyZlapany = true;
                else
                    czyZlapany = false;
                break;
            case "ocena_3":
                number = Random.Range(0, 5);
                if (number >=2)
                    czyZlapany = true;
                else
                    czyZlapany = false;
                break;
            case "ocena_4":
                number = Random.Range(0, 5);
                if (number >= 1)
                    czyZlapany = true;
                else
                    czyZlapany = false;
                break;
            case "ocena_5":
                czyZlapany = true;
                break;
        }
    }

}
