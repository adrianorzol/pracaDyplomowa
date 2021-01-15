using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateRozaWiatrow : MonoBehaviour
{
    Vector3 FirstPoint;
    Vector3 SecondPoint;
    float zAngle;

    float zAngleTemp;


    void Start()
    {
        zAngle = 0;

        this.transform.rotation = Quaternion.Euler(0, 0, zAngle);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                FirstPoint = Input.GetTouch(0).position;
                zAngleTemp = zAngle;

            }
            if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                SecondPoint = Input.GetTouch(0).position;
                zAngle = zAngleTemp + (SecondPoint.x - FirstPoint.x) * 180 / Screen.width;

                this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -zAngle);
            }
        }

    }
}
