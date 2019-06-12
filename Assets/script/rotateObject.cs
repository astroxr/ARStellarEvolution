using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // rotate nebula (and star)
        transform.Rotate(0, 30*Time.deltaTime, 0);
    }
}
