using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogmanager : MonoBehaviour
{   

    public GameObject frog;

    public GameObject frogPrefab;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (frog != null)
               Destroy(frog);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (frog == null)
            frog = Instantiate(frogPrefab, new Vector3(0, -5, 0), Quaternion.identity);
        }
    }     
}
