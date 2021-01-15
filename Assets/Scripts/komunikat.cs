using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class komunikat : MonoBehaviour
{
    public GameObject tlo;
    
    
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ObszarGry")
        {
            tlo.transform.localScale = new Vector3(0, 0, 0);
            
        }
        
    }
    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ObszarGry")
        {
            tlo.transform.localScale = new Vector3(1, 1, 1);
            
        }
        
    }
}
