using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    float speed = 0.1f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos); 
        if (squareInScreenSpace.x < 0 || squareInScreenSpace.x > Screen.width)
        {
            speed *= -1;
        }

        pos.x += speed;
        transform.position = pos;
    }
}
