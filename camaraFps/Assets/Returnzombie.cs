using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Returnzombie : MonoBehaviour
{
    //retorna un Zombie
    Zombie GetZombie()
    {
        return (Zombie)GameObject.FindObjectOfType(typeof(Zombie));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Zombie target = GetZombie();
        if(target != null)
        {
            Debug.DrawLine(transform.position, GetZombie().transform.position);
        }
    }
}
