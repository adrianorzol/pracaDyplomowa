using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Zegar : MonoBehaviour
{
    public float timeRemaining = 10f;
    public bool timerIsRunning = false;
    public GameObject timeText;
    

    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            timeText = GameObject.Find(name + "Plecak");
            GameObject.Find(name + "Plecak").GetComponent<CanvasGroup>().alpha = 1;
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
                
            }
        }
        if (GameObject.Find(name + "Plecak"))
        {
            
        }
        


    }
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(name);

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        ProgresZegara data = SystemZapisywaniaZegara.WczytaniePostepu();
        if(data != null)
        {
            switch (name)
            {
                case "ZegarWBiB":
                    {
                        timeRemaining = data.czasWBiB;
                        timerIsRunning = data.czyWBiB;
                        break;
                    }
                case "ZegarWBZ":
                    {
                        timeRemaining = data.czasWBZ;
                        timerIsRunning = data.czyWBZ;
                        break;
                    }
                case "ZegarWG":
                    {
                        timeRemaining = data.czasWG;
                        timerIsRunning = data.czyWG;
                        break;
                    }
                case "ZegarWH":
                    {
                        timeRemaining = data.czasWH;
                        timerIsRunning = data.czyWH;
                        break;
                    }
                case "ZegarWMiI":
                    {
                        timeRemaining = data.czasWMiI;
                        timerIsRunning = data.czyWMiI;
                        break;
                    }
                case "ZegarWMW":
                    {
                        timeRemaining = data.czasWMW;
                        timerIsRunning = data.czyWMW;
                        break;
                    }
                case "ZegarWNE":
                    {
                        timeRemaining = data.czasWNE;
                        timerIsRunning = data.czyWNE;
                        break;
                    }
                case "ZegarWNoZ":
                    {
                        timeRemaining = data.czasWNoZ;
                        timerIsRunning = data.czyWNoZ;
                        break;
                    }
                case "ZegarWNT":
                    {
                        timeRemaining = data.czasWNT;
                        timerIsRunning = data.czyWNT;
                        break;
                    }
                case "ZegarWPiA":
                    {
                        timeRemaining = data.czasWPiA;
                        timerIsRunning = data.czyWPiA;
                        break;
                    }
                case "ZegarWRiL":
                    {
                        timeRemaining = data.czasWRiL;
                        timerIsRunning = data.czyWRiL;
                        break;
                    }
            }
        }

    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        if(timeText)
            timeText.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
