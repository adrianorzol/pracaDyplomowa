using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWH : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WH");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWH"))
        {
            if (GameObject.Find("ZegarWH").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20456.38f, 53750.05f, -9.696777f);
            }
        }

    }
}