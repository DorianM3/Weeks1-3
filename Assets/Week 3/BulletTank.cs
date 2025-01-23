using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTank : MonoBehaviour
{
    public float speed = 5;
    public bool hasBeenFired = false;

    // Update is called once per frame
    void Update()
    {
{
        if (hasBeenFired)
        {
            Movement(); 
        }
    }


    void Movement()
    {
        transform.position += transform.up * speed * Time.deltaTime; 
    }

    }
}
