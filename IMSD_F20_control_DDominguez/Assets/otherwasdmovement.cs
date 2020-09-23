using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherwasdmovement : MonoBehaviour
{

    public Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {

    }
        
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            myTransform.position += Vector3.left;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            myTransform.position += Vector3.right;
        }
    }
}
