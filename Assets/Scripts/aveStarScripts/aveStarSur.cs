using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aveStarSur : MonoBehaviour
{
    public double aveStarSurfaceSize;
    ParticleSystem.MainModule aveSurfaceColor;

    // Start is called before the first frame update
    void Start()
    {
        aveStarSurfaceSize = 0;
        aveSurfaceColor = GetComponent<ParticleSystem>().main;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 0.3f)
        {
            transform.localScale += new Vector3(0.02f * Time.deltaTime,
            0.02f * Time.deltaTime, 0.02f * Time.deltaTime);

            if (transform.localScale.x > 0.1)
            {
                aveStarSurfaceSize = 0.1;
            }

            if (transform.localScale.x > 0.15)
            {
                aveStarSurfaceSize = 0.15;
                aveSurfaceColor.startColor = new ParticleSystem.MinMaxGradient(new Color(0.9137255f, 0.3886809f, 0.1254902f));
            }
        }
        else
        {
            aveStarSurfaceSize = 0.3;
            Destroy(gameObject);
        }
    }
}

