using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour
{
    Vector3 rotacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float mouseX;
    float mouseY;
    public bool InvertedMouse;
    //public GameObject body = GameObject.Find("Player");

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
        GameObject body = GameObject.Find("Player");
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);
        body.transform.eulerAngles = new Vector3(0, mouseX, 0);

      
        
       
        
    }
}
