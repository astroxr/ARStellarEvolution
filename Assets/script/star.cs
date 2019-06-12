using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    public Color starColor = Color.black;
    public Renderer rend;
    public GameObject starSur, nova, nova1, nova2, nova3;
    public starsur theStarSur;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = starColor;
        theStarSur = starSur.GetComponent<starsur>();
        nova.SetActive(false);
        nova1.SetActive(false);
        nova2.SetActive(false);
        nova3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (theStarSur.starSurSize == 0.004)
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

        if (theStarSur.starSurSize == 0.01)
        {
            transform.localScale = new Vector3(0, 0, 0);
            nova.SetActive(true);
            nova1.SetActive(true);
            nova2.SetActive(true);
            nova3.SetActive(true);
        }
    }

}
