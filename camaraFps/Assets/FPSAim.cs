using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour
{

    void Start()
    {
        Cursor.visible = false;
    }

    float mouseX;
    float mouseY;
    public bool InvertedMouse;
    public GameObject body;

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else 
        {
            mouseY -= Input.GetAxis("Mouse Y");

        } 
        Debug.Log(mouseX);
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
        body.transform.eulerAngles = new Vector3(0, mouseX, 0);
 
    }
}
