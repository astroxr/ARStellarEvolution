using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSurfaceBehaviour : MonoBehaviour
{
    public double starSurfaceSize;
    ParticleSystem.MainModule surfaceColor;

    // Start is called before the first frame update
    void Start()
    {
        starSurfaceSize = 0;
        surfaceColor = GetComponent<ParticleSystem>().main;

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
                starSurfaceSize = 0.1;
            }

            if (transform.localScale.x > 0.15)
            {
                starSurfaceSize = 0.15;
                surfaceColor.startColor = new ParticleSystem.MinMaxGradient(Color.red);
            }
        }
        else
        {
            starSurfaceSize = 0.3;
            Destroy(gameObject);
        }
    }
}
