using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWMiI : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WMiI");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWMiI"))
        {
            if (GameObject.Find("ZegarWMiI").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20455.9f, 53743.55f, -8.429688f);
            }
        }

    }
}