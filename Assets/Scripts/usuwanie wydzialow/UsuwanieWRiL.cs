using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWRiL : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WRiL");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWRiL"))
        {
            if (GameObject.Find("ZegarWRiL").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20459.63f, 53759.12f, -11.5979f);
            }
        }

    }
}