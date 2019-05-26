using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * test code to see if simple rigid body 
 * would have the same black background problem
 */

public class Loop : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10)
            Respawn();
    }

    private void Respawn()
    {
        transform.position = new Vector3(0, 10);

        var fall = GetComponent<Rigidbody>();
        fall.velocity = Vector3.zero;
    }
}
