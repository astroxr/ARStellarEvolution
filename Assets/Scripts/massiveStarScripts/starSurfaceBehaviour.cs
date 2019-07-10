using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSurfaceBehaviour : MonoBehaviour
{
    public double starSurfaceSize;
    ParticleSystem.MainModule surfaceColor;
    public float delay = 8f;
    float countdown, secondcountdown;

    // Start is called before the first frame update
    void Start()
    {
        starSurfaceSize = 0.15;
        surfaceColor = GetComponent<ParticleSystem>().main;
        countdown = delay;
        secondcountdown = delay;

    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            ChangeSizeMass();
        }

    }

    public void ChangeSizeMass()
    {
        if (transform.localScale.x < 0.3f)
        {
            transform.localScale += new Vector3(0.02f * Time.deltaTime,
            0.02f * Time.deltaTime, 0.02f * Time.deltaTime);

            if (transform.localScale.x > 0.2f)
            {
                starSurfaceSize = 0.2;
                surfaceColor.startColor = new ParticleSystem.MinMaxGradient(new Color(0.9150943f, 0.125178f, 0.1557938f));
            }
        }
        else
        {
            secondcountdown -= Time.deltaTime;
            if (secondcountdown <= 0)
            {
                starSurfaceSize = 0.3;
                Destroy(gameObject);
            }
        }
    }
}
