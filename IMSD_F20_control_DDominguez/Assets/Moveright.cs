using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveright : MonoBehaviour
{
    
    public Transform myTransform;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myTransform.position = new Vector3(-10, myTransform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.position = myTransform.position + new Vector3(1, 0, 0) * speed * Time.deltaTime;
    }
}
