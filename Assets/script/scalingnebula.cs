using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalingnebula : MonoBehaviour
{
    void Update()
    {
        transform.localScale -= new Vector3(Time.deltaTime * 0.01f,
            Time.deltaTime * 0.01f, Time.deltaTime * 0.01f);
        if (transform.localScale.x < 0)
        {
            transform.localScale = new Vector3(0, 0, 0);
            Destroy(gameObject);
        }
            
    }
    
}
