using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWNoZ : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WNoZ");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if (GameObject.Find("ZegarWNoZ"))
        {
            if (GameObject.Find("ZegarWNoZ").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20459.42f, 53760.75f, -12.63323f);
            }
        }

    }
}