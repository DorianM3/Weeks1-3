using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDemo : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime; 
        transform.localScale = Vector2.one * curve.Evaluate(t % 1);
    }
}
