using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starmotion : MonoBehaviour
{
    public Color starColor = Color.black;
    public Renderer rend;
    public GameObject scaleNebula;
    public scalingnebula theNebula;
    public double nebula;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = starColor;
        theNebula = scaleNebula.GetComponent<scalingnebula>();
    }

    // Update is called once per frame
    void Update()
    {
        if (theNebula.nebulaSize == 0)
        {
            if (starColor.r < 1)
            {
                starColor.r += 0.25f * Time.deltaTime;
                starColor.b -= 0.5f * Time.deltaTime;
                starColor.g -= 0.5f * Time.deltaTime;
                rend.material.color = starColor;
            }
            else
            {
                rend.material.color = starColor;
            }
        }
    }
    
}
