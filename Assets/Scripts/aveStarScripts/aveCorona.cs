using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aveCorona : MonoBehaviour
{
    ParticleSystem.MainModule aveCoronaColor;
    // Start is called before the first frame update
    void Start()
    {
        aveCoronaColor = GetComponent<ParticleSystem>().main;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 0.3f)
        {
            transform.localScale += new Vector3(0.02f * Time.deltaTime,
            0.02f * Time.deltaTime, 0.02f * Time.deltaTime);

            if (transform.localScale.x > 0.15)
            {
                aveCoronaColor.startColor = new ParticleSystem.MinMaxGradient(new Color (0.8490566f, 0.8490566f, 0.5166429f));

            }
        }
    }
}
