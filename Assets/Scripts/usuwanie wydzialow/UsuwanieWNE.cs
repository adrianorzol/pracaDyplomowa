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
}