﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    float speed = 15.0f;

    void Update()
    {
        if (Input.GetButtonUp("Jump") && GetComponent<Rigidbody>().velocity == new Vector3(0, 0, 0))
        {
            GetComponent<Rigidbody>().AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        }
    }
}