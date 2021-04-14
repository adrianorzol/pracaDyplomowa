using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Audio;
using UnityEngine.UI;

public class gpsLocation : MonoBehaviour
{
    private float longitude;
    private float latitude;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        
        if (Input.location.isEnabledByUser)
            StartCoroutine(GetLocation());
        else
            Permission.RequestUserPermission(Permission.FineLocation);
    }

    private IEnumerator GetLocation()
    {
       
            Input.location.Start();
            while (Input.location.status == LocationServiceStatus.Initializing)
            {
                yield return new WaitForSeconds(0.5f);
            }
            latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;
            yield break;
        
    }

    // Update is called once per frame
    void Update()
    {
       
            latitude = Input.location.lastData.latitude * 1000;
            longitude = Input.location.lastData.longitude * 1000;
            gameObject.transform.position = new Vector3(longitude, latitude, 0f);
        
        
    }
}
