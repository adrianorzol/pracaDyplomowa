using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWPiA : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WPiA");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWPiA"))
        {
            if (GameObject.Find("ZegarWPiA").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20458.27f, 53750.57f, -1.296182f);
            }
        }

    }
}