using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PamiecSuwaka : MonoBehaviour
{
    public string rodzaj;
    // Start is called before the first frame update
    void Start()
    {
        if(rodzaj == "wibracje")
            this.GetComponent<Toggle>().isOn = GameObject.Find("Zamykanie").GetComponent<ZamykanieAplikacji>().czyWibracje;
        if (rodzaj == "dzwiek")
            this.GetComponent<Toggle>().isOn = GameObject.Find("Zamykanie").GetComponent<ZamykanieAplikacji>().czyDzwiek;
    }
}
