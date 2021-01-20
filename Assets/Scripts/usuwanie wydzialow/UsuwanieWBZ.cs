using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWBZ : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WBZ");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWBZ"))
        {
            if (GameObject.Find("ZegarWBZ").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20460.22f, 53757.57f, -9.043457f);
            }
        }

    }
}