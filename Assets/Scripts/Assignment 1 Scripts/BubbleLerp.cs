using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLerp : MonoBehaviour
{
    //Creates the range for the bubble to expand and shrink as variable t 
    [Range(0, 1)]
    public float t;
    public float flip;
    public Boolean checkpress; 

    public AnimationCurve wave; 
    // Start is called before the first frame update
    void Start()
    {
        t = 0.1f;
        flip = 0.2f; 
    }

    // Update is called once per frame
    void Update()
    {

        //This if statement checks if the bubble has grown to either its max or minimum size so the player doesn't have to manually drag the t range 
        if(t >= 1 || t <= 0)
        {
            //Flips the sign of the float being added to t effectively changing whether it shrinks or grows 
            flip *= -1; 
        }

        //Takes a key input for when the bubbles should start changing in size
        if (Input.GetKey(KeyCode.D))
        {
            checkpress = true; 
        }

        //Take a key input for if the bubbles should disappear, with them being moved off screen to imply they popped 
        if (Input.GetKey(KeyCode.P))
        {
            transform.position = Vector3.one * -10;
            Debug.Log("Pop!"); 
        }

        //If the player inputted the button to get the bubble moving, the if statement is true and lets t change 
        if (checkpress)
        {
            t += flip * Time.deltaTime;
        }
        
        //Changes the scale based on the wave given in the inspector so how the bubble moves can be easily changed between bubbles 
        transform.localScale = Vector2.one * wave.Evaluate(t); 
    }
}
