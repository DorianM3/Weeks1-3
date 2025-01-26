using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpPatrol : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public float tminus; 
    public Transform start;
    public Transform end;


    // Start is called before the first frame update
    void Start()
    {
        //Tminus is so we can add to t automatically without needing to adjust the slider 
        tminus = -0.1f; 
    }

    // Update is called once per frame
    void Update()
    {
        //This line is what allows for the translation between two empty gameobjects 
        transform.position = Vector2.Lerp(start.position, end.position, t);
        //If our object hits either side of the screen the direction flips
        if(t <= 0 || t >= 1)
        {
            tminus *= -1; 
        }

        //Adds or subtracts to t and uses time.deltatime to assure the pace is steady 
        t += tminus * Time.deltaTime;
    }
}
