using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createStar : MonoBehaviour
{
    public GameObject nebula, rotatingNebula,bornStar,star;
    public float delay = 3f;
    float countdown;

    public void Start()
    {
        star.SetActive(false);
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        if (bornStar == null)
        {
            star.SetActive(true);
            destroyNebula();
        }
    }

    public void destroyNebula()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Destroy(rotatingNebula);
            Destroy(nebula);
            enabled = false;
        }
    }
}
