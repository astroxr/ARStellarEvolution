using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * test code to see if simple rigid body 
 * would have the same black background problem
 */

public class loopnow : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
            Respawn();
    }

    private void Respawn()
    {
        transform.position = new Vector3(0, 1);

        var fall = GetComponent<Rigidbody>();
        fall.velocity = Vector3.zero;
    }
}
