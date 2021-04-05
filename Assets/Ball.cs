using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;
    public int speed = 1;
    int vecX = 1;
    int vecY = 1;

    // Update is called once per frame
    void Update()
    {
        var tempPos = transform.position;
         
        tempPos.x += vecX * speed * Time.deltaTime;
        tempPos.y += vecY * speed * Time.deltaTime;


        if (tempPos.x >= 7.75)
        {
            tempPos.x = 0;
            tempPos.y = 0;
            paddle.reset();

        }

        if (tempPos.x <= -7.75)
        {
            vecX = 1;
        }

        if (tempPos.y >= 4.75)
        {
            vecY = -1;
        }

        if (tempPos.y <= -4.75)
        {
            vecY = 1;
        }


        transform.position = tempPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        vecX = -1;
    }
}
