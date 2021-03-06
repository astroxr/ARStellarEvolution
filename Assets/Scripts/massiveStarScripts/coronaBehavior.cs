﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coronaBehavior : MonoBehaviour
{
    ParticleSystem.MainModule coronaColor;
    public float delay = 8f;
    float countdown;

    void Start()
    {
        coronaColor = GetComponent<ParticleSystem>().main;
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            ChangeSizeCoronaMass();
        }

    }

    public void ChangeSizeCoronaMass()
    {
        if (transform.localScale.x < 0.3f)
        {
            transform.localScale += new Vector3(0.02f * Time.deltaTime,
            0.02f * Time.deltaTime, 0.02f * Time.deltaTime);
            if (transform.localScale.x > 0.2f)
            {
                coronaColor.startColor = new ParticleSystem.MinMaxGradient(new Color(0.9339623f, 0.9327107f, 0.02202741f));
            }

        }
    }
}
