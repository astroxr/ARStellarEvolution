using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteDwarfBehaviour : MonoBehaviour
{
    void Update()
    {
        if (transform.localScale.x < 0.1f)
        {
            transform.localScale += new Vector3(0.03f * Time.deltaTime,
            0.03f * Time.deltaTime, 0.03f * Time.deltaTime);
        }
    }
}
