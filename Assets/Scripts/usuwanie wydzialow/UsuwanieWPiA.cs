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
}