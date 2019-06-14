using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleBlackHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 5f) 
        {
            transform.localScale += new Vector3(1.2f * Time.deltaTime, 1.2f * Time.deltaTime,
            1.2f * Time.deltaTime);
        }
        
    }
}
