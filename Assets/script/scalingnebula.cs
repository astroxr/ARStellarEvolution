using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalingnebula : MonoBehaviour
{
    public double nebulaSize;

    void Start()
    {
        nebulaSize = 0.08;
    }

    void Update()
    {
        transform.localScale -= new Vector3(Time.deltaTime * 0.01f,
            Time.deltaTime * 0.01f, Time.deltaTime * 0.01f);
        nebulaSize = 0.08f;
        if (transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(0, 0, 0);
            nebulaSize = 0;
        }
            
    }
    
}
