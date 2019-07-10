using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aveStarSur : MonoBehaviour
{
    public double aveStarSurfaceSize;
    ParticleSystem.MainModule aveSurfaceColor;
    public float delay = 8f;
    float countdown, secondcountdown;

    // Start is called before the first frame update
    void Start()
    {
        aveStarSurfaceSize = 0.15;
        aveSurfaceColor = GetComponent<ParticleSystem>().main;
        countdown = delay;
        secondcountdown = delay;

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            ChangeSize();
        }

    }

    public void ChangeSize()
    {
        if (transform.localScale.x < 0.3f)
        {
            transform.localScale += new Vector3(0.02f * Time.deltaTime,
            0.02f * Time.deltaTime, 0.02f * Time.deltaTime);

            if(transform.localScale.x > 0.2f)
            {
                aveStarSurfaceSize = 0.2;
                aveSurfaceColor.startColor = new ParticleSystem.MinMaxGradient(new Color(0.9137255f, 0.3886809f, 0.1254902f));
            }
        }
        else
        {
            secondcountdown -= Time.deltaTime;
            if (secondcountdown <= 0)
            {
                aveStarSurfaceSize = 0.3;
                Destroy(gameObject);
            }

        }
    }
}

