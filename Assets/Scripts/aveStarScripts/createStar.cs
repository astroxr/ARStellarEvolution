using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createStar : MonoBehaviour
{
    public GameObject nebula;
    public GameObject star;

    public void Start()
    {
        star.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (nebula == null)
        {
            star.SetActive(true);
            enabled = false;
        }
    }
}
