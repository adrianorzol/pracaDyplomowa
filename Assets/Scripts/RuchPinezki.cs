using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuchPinezki : MonoBehaviour
{
    public GameObject pinezka;
    public Vector3 pozycja;
    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Button>().onClick.AddListener(Klik);
    }

    // Update is called once per frame
    void Klik()
    {
        pinezka.GetComponent<RectTransform>().anchoredPosition = pozycja;
        pinezka.GetComponent<CanvasGroup>().alpha = 1;
        

    }
}
