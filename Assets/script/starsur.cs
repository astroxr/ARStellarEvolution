using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsur : MonoBehaviour
{

    public ParticleSystem myParticleSystem;
    public ParticleSystem.ColorOverLifetimeModule colorModule;
    public Color starSurColor = Color.black;

    void Start()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
        colorModule = myParticleSystem.colorOverLifetime;
    }

    // Update is called once per frame
    void Update()
    {
        // increase the size of the star
        transform.localScale += new Vector3(Time.deltaTime * 0.0005f,
            Time.deltaTime * 0.0005f, Time.deltaTime * 0.0005f);

        if (transform.localScale.x > 0.004f)
        {
            // change color of the star surface from blue to red
            if (starSurColor.r < 0.5)
            {
                starSurColor.r += 0.25f * Time.deltaTime;
                starSurColor.b -= 0.5f * Time.deltaTime;
                starSurColor.g -= 0.5f * Time.deltaTime;
                colorModule.color = starSurColor;
            }
            
        }

        if (transform.localScale.x > 0.012f)
        {
            transform.localScale = new Vector3(0.012f,0.012f,0.012f);
        }
    }
}
