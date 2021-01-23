using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Odciemnianie : MonoBehaviour
{
    public string wydzial;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
       if (GameObject.FindGameObjectWithTag(wydzial).GetComponent<Transform>().position == new Vector3(0f, 0f, 0f))
            GetComponent<Image>().color = new Vector4(255, 255, 255, 255);
    }
}
