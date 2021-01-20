using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWMW : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WMW");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWMW"))
        {
            if (GameObject.Find("ZegarWMW").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20457.45f, 53749.12f, -12.43292f);
            }
        }

    }
}