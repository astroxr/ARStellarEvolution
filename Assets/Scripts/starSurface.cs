using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSurface : MonoBehaviour
{
    public ParticleSystem myParticleSystem;
    public ParticleSystem.ColorOverLifetimeModule colorModule;
    public Color starSurColor;
    public double starSurSize;
    public float delay = 5f;
    float countdown;

    // Start is called before the first frame update
    void Start()
    {
        myParticleSystem = GetComponent<ParticleSystem>();
        colorModule = myParticleSystem.colorOverLifetime;
        starSurColor = Color.blue;
        starSurSize = 0;
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            transform.localScale += new Vector3(0.01f * Time.deltaTime, 0.01f * Time.deltaTime,
           0.01f * Time.deltaTime);

            if (transform.localScale.x > 0.05f && transform.localScale.x < 0.1f)
            {
                starSurSize = 0.05;
                starSurColor.r += 0.25f * Time.deltaTime;
                starSurColor.b -= 0.5f * Time.deltaTime;
                starSurColor.g -= 0.5f * Time.deltaTime;
                colorModule.color = starSurColor;

            }

            if (transform.localScale.x > 0.1f)
            {
                starSurSize = 0.1;
                enabled = false;
                Destroy(gameObject);
            }
        }
           

    }
}
