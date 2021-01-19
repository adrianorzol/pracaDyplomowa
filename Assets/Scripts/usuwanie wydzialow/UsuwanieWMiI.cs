using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UsuwanieWMiI : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("WMiI");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }


    }
}