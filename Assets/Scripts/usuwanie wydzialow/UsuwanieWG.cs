using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWG : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WG");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        
    }
    void Update()
    {
        if (GameObject.Find("ZegarWG"))
        {
            if (GameObject.Find("ZegarWG").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20458.08f, 53760.48f, -9.696777f);
            }
        }

    }
}