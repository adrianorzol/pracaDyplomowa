using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZamykanieAplikacji : MonoBehaviour
{
    public bool czyWibracje;
    public bool czyDzwiek;
    public static ZamykanieAplikacji instance;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        if (GameObject.Find("ToggleWibracje"))
        {
            GameObject.Find("ToggleWibracje").GetComponent<Toggle>().isOn = czyWibracje;
        }
        if (GameObject.Find("ToggleDzwiek"))
        {
            GameObject.Find("ToggleDzwiek").GetComponent<Toggle>().isOn = czyDzwiek;
        }
    }
    // Update is called once per frame
    void Update()
    {
          
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                // Quit the application
                Application.Quit();
            }
        }
    }
}
