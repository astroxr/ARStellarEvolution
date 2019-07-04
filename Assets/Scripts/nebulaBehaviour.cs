using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nebulaBehaviour : MonoBehaviour
{
    public float nebulaSize;
    public float delay = 5f;
    float countdown;
    ParticleSystem.MainModule nebulaCount;

    // Start is called before the first frame update
    void Start()
    {
        nebulaSize = 0.5f;
        nebulaCount = GetComponent<ParticleSystem>().main;
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
        nebulaCount.maxParticles += 50;
        if (nebulaCount.maxParticles > 10000)
        {
            Destroy(gameObject);
        }
    }
}
