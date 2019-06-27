using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coronaBehavior : MonoBehaviour
{
    ParticleSystem.MainModule coronaColor;
    // Start is called before the first frame update
    void Start()
    {
        coronaColor = GetComponent<ParticleSystem>().main;
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
                coronaColor.startColor = new ParticleSystem.MinMaxGradient(Color.yellow);

            }
        }
    }
}
