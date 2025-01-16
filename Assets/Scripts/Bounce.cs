using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private float speedX;
    private float speedY;
    // Start is called before the first frame update
    void Start()
    {
      float speedX = Random.Range(-1.0f, 1.0f);
      float speedY = Random.Range(-1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 pos = transform.position;

        if (pos.x < 0 || pos.x > Screen.width)
        {
            speedX *= -0.1f;
        }

        if(pos.y < 0 || pos.y > Screen.height)
        {
            speedY *= -0.1f; 
        }

        pos.x += speedX * Time.deltaTime;
        pos.y += speedY * Time.deltaTime;

        transform.position += pos; 
       */ 
    }
}
