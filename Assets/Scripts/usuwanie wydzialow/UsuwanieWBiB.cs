using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWBiB : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WBiB");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
    void Update()
    {
        if(GameObject.Find("ZegarWBiB"))
        {
            if (GameObject.Find("ZegarWBiB").GetComponent<Zegar>().timeRemaining <= 0.5f)
            {
                transform.position = new Vector3(20460.75f, 53759.12f, -9.088684f);
            }
        }
        
    }
}