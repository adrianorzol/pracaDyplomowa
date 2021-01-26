using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muzyka : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ToggleDzwiek"))
            {
                if (GameObject.Find("ToggleDzwiek").GetComponent<Toggle>().isOn == true)
                    GetComponent<AudioSource>().mute = true;
                else
                    GetComponent<AudioSource>().mute = false;
             }
        
    }
}
