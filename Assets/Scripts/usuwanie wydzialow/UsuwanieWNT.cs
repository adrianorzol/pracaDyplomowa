using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWNT : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WNT");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWNT"))
        {
            if (GameObject.Find("ZegarWNT").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20459.88f, 53754.31f, -12.45557f);
            }
        }

    }
}