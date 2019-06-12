using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsur : MonoBehaviour
{

    public ParticleSystem myParticleSystem;
    public ParticleSystem.ColorOverLifetimeModule colorModule;
    public Color starSurColor = Color.black;
    public double starSurSize;

    void Start()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
        colorModule = myParticleSystem.colorOverLifetime;
        starSurSize = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // increase the size of the star
        transform.localScale += new Vector3(Time.deltaTime * 0.0005f,
            Time.deltaTime * 0.0005f, Time.deltaTime * 0.0005f);

        if (transform.localScale.x > 0.004f && transform.localScale.x < 0.01f)
        {
            starSurSize = 0.004;
            if (starSurColor.r < 0.5)
            {
                starSurColor.r += 0.25f * Time.deltaTime;
                starSurColor.b -= 0.5f * Time.deltaTime;
                starSurColor.g -= 0.5f * Time.deltaTime;
                colorModule.color = starSurColor;
            }

        }

        if (transform.localScale.x > 0.01f)
        {
            transform.localScale = new Vector3(0, 0, 0);
            starSurSize = 0.01;
            blackhole();
            enabled = false;
        }
    }

    void blackhole()
    {
        //change to black hole
    }
}
