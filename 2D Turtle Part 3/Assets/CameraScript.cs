using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float horizontalSpeed = 0.5f;
    float verticalSpeed = 0.5f;
    bool leftButtonHeld = false;
    // Update is called once per frame
    void Update()
    {
        if(leftButtonHeld==false)
        {
            if(Input.GetMouseButton(0)==true)
            {
                leftButtonHeld = true;
            }
        }
        else
        {
            if(Input.GetMouseButton(0)==false)
            {
                leftButtonHeld = false;
            }
        }
        if(leftButtonHeld==true)
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            Vector2 mouseVector = new Vector2(-h, -v);
            transform.Translate(mouseVector);
        }
        if(Input.mouseScrollDelta.y!=0)
        {
            Camera.main.orthographicSize += Input.mouseScrollDelta.y*1.0f;



            /*float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            float z = scaleSpeed * Input.mouseScrollDelta.y;
            Vector3 scrollVector = new Vector3(h, v, z);
            transform.Translate(scrollVector);*/
        }
    }
}
