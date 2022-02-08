using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithInput : MonoBehaviour
{
    float speed = 0.022f;

    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, speed, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, -speed, 0);
        }
    }
}
