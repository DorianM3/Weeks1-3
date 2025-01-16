using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private float speedX;
    private float speedY;
    Vector3 plus;
    // Start is called before the first frame update
    void Start()
    {
       plus = new Vector3(0.01f, 0.01f, 0);
       speedX = Random.Range(-5.0f, 5.0f);
       speedY = Random.Range(-5.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speedX * Time.deltaTime;
        pos.y += speedY * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x < 0)
        {
            Vector3 fixedPos = new Vector3(0,0,0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speedX *= -1f;
        }

        if(screenPos.x > Screen.width)
        {
            Vector3 fixedPos = new Vector3(Screen.width, 0, 0);
            pos.x = Camera.main.ScreenToWorldPoint(fixedPos).x;
            speedX *= -1f;
        }

        if (screenPos.y < 0)
        {
            Vector3 fixedPos = new Vector3(0, 0, 0);
            pos.y = Camera.main.ScreenToWorldPoint(fixedPos).y;
            speedY *= -1f;
        }

        if (screenPos.y > Screen.height)
        {
            Vector3 fixedPos = new Vector3(0, Screen.height, 0);
            pos.y = Camera.main.ScreenToWorldPoint(fixedPos).y;
            speedY *= -1f;
        }

        transform.position = pos;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localScale += plus; 
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.localScale.x > 0.01)
        {
            transform.localScale -= plus;
        }

    }
}
