using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMove : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        //Makes a new vector for duck position so we can directly change the transformed objects position
        Vector2 duckPos = transform.position;
        //Makes said vector relative to the game screen and follow the mouses x input so the duck can follow the mouse 
        duckPos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        //Checks to see if the duck is in bounds, if so then proceed as normal 
        if(transform.position.x < 8 && transform.position.x > -8)
        {
            transform.position = duckPos;
        }

        //If the mouse is out of bounds the duck is stuck and therefor needs to be picked up and placed elsewhere in the bath
        else
        {
            Debug.Log("You're stuck! Use R to reset position!");
        }

        //If the user presses R they free the duck back to wherever their mouse currently is and can play with it again!
        if (Input.GetKey(KeyCode.R))
        {
            duckPos.x = 0;
            transform.position = duckPos;
        }
    }
}
