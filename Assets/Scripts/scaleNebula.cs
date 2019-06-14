using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleNebula : MonoBehaviour
{
    public float delay = 5f;
    float countdown;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0)
        {
            if (transform.localScale.x > 0)
            {
                transform.localScale -= new Vector3(0.1f * Time.deltaTime, 0.1f * Time.deltaTime,
                0.1f * Time.deltaTime);
            }
        }
        
        
    }
}
