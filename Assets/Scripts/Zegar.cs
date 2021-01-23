using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Zegar : MonoBehaviour
{
    public float timeRemaining = 10;
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
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                
                timeRemaining = 0;
                timerIsRunning = false;
                Destroy(this.gameObject);
            }
        }
        if (GameObject.Find(name + "Plecak"))
        {
            timeText = GameObject.Find(name + "Plecak");
            GameObject.Find(name + "Plecak").GetComponent<CanvasGroup>().alpha = 1;
        }
        


    }
    void Awake()
    {
        
            
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
