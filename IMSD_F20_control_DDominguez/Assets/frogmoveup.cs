﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogmoveup : MonoBehaviour
{
    // Start is called before the first frame update
    Transform myTransform;


    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
           myTransform.position += new Vector3(0, Time.deltaTime * speed, 0);
        }

        if ( Input.GetKeyUp(KeyCode.W))
        {
           myTransform.position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            myTransform.position += new Vector3(0, -Time.deltaTime * speed, 0);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            myTransform.position += Vector3.up;
        }
    }
}
