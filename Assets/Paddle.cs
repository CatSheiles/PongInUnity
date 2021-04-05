using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int speed = 1;

    Vector3 tempPos;

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.position;

        if (Input.GetKey("up"))
        {
            if(tempPos.y <= 4.2)
            tempPos.y += 1 * speed * Time.deltaTime;
            
        }

        if (Input.GetKey("down"))
        {
            if(tempPos.y >= -4.2)
            tempPos.y -= 1 * speed * Time.deltaTime;
        }

        transform.position = tempPos;
    }

    public void reset()
    {
        tempPos.y = 0;
        transform.position = tempPos;
    }
}
