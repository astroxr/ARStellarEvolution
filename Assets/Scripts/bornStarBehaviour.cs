using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bornStarBehaviour : MonoBehaviour
{
    public float delay = 5f;
    float countdown;
    ParticleSystem.MainModule bornStarCount;

    // Start is called before the first frame update
    void Start()
    {
        bornStarCount = GetComponent<ParticleSystem>().main;
        countdown = delay;
    }

    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            ActionNebula();
        }
    }

    public void ActionNebula()
    {
        bornStarCount.maxParticles += 50;
        transform.localScale += new Vector3(0.01f * Time.deltaTime,
            0.01f * Time.deltaTime, 0.01f * Time.deltaTime);

        if (transform.localScale.x > 0.13f)
        {
            Destroy(gameObject);
        }
    }
}
