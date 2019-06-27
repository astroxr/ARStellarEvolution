using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackHoleBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale.x < 10)
        {
            transform.localScale += new Vector3(2.5f * Time.deltaTime,
            2.5f * Time.deltaTime, 2.5f * Time.deltaTime);
        }

    }
}
