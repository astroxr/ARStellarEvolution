﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nebulaBehaviour : MonoBehaviour
{
    public float nebulaSize;

    // Start is called before the first frame update
    void Start()
    {
        nebulaSize = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x > 0)
        {
            transform.localScale -= new Vector3(0.1f * Time.deltaTime,
            0.1f * Time.deltaTime, 0.1f * Time.deltaTime);
        }

        else
        {
            nebulaSize = 0;
            Destroy(gameObject);
        }

    }
}