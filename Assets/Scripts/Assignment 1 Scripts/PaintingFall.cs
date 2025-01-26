using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Presets;
using UnityEngine;

public class PaintingFall : MonoBehaviour
{
    //A boolean made to check if the player has made the input for the painting to fall
    public Boolean checkfall; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Makes a vector so we can effect the position of our painting 
        Vector2 fall = transform.position; 

        //Checks to see if left click was pressed as this is the trigger for the event to happen 
        if (Input.GetMouseButtonDown(0))
        {
            checkfall = true;
        }

        //If the player did press left click, the painting will slip off the wall, and spiral into the bath
        if(checkfall == true)
        {
            fall.y -= 9 * Time.deltaTime;
            transform.Rotate(0, 0, 65 * Time.deltaTime);
        }

        //We make our position equal to fall as it has the same x value with a y value that's constantly going down so it can make the painting fall 
        transform.position = fall; 
    }
}
