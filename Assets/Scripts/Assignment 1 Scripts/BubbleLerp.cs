using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleLerp : MonoBehaviour
{
    //Creates the range for the bubble to expand and shrink as variable t 
    [Range(0, 1)]
    public float t;
    public float flip; 

    public AnimationCurve wave; 
    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        flip = -0.5f; 
    }

    // Update is called once per frame
    void Update()
    {

        //This if statement checks if the bubble has grown to either its max or minimum size so the player doesn't have to manually drag the t range 
        if(t >= 1 || t <= 0)
        {
            //Flips the sign of the float being added to t effectively changing its direction 
            flip *= -1; 
        }

        //What let's the bubble change size on its own 
        t += flip * Time.deltaTime; 
        
        //Changes the scale based on the wave given in the inspector so how the bubble moves can be easily changed between bubbles 
        transform.localScale = Vector2.one * wave.Evaluate(t); 
    }
}
