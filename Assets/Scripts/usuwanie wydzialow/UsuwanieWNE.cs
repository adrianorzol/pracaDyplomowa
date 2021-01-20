using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWNE : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WNE");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWNE"))
        {
            if (GameObject.Find("ZegarWNE").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20460.67f, 53760.23f, -12.45557f);
            }
        }

    }
}