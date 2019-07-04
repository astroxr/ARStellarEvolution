using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aveCorona : MonoBehaviour
{
    ParticleSystem.MainModule aveCoronaColor;
    public float delay = 8f;
    float countdown;

    void Start()
    {
        aveCoronaColor = GetComponent<ParticleSystem>().main;
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            ChangeSizeCorona();
        }
    }


    public void ChangeSizeCorona()
    {
        if (transform.localScale.x < 0.3f)
        {
            transform.localScale += new Vector3(0.02f * Time.deltaTime,
            0.02f * Time.deltaTime, 0.02f * Time.deltaTime);
            aveCoronaColor.startColor = new ParticleSystem.MinMaxGradient(new Color(0.8490566f, 0.8490566f, 0.5166429f));

        }
    }
}
