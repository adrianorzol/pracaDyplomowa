using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UkrywanieZegara : MonoBehaviour
{
    public string wydzial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("Zegar" + wydzial).GetComponent<Zegar>().timerIsRunning == false)
        {
            GetComponent<CanvasGroup>().alpha = 0;
        }
        
    }
}
