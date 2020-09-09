using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movedisc : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform myTransform;

    public float speed;

    private float timer;
    void Start()
    {
        myTransform.position = new Vector3(-10, myTransform.position.y, 0);
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            myTransform.position += new  Vector3(1, 0, 0);
        }
    }
}
