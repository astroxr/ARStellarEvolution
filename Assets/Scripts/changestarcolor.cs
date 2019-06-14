using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changestarcolor : MonoBehaviour
{
    public Color starColor = Color.black;
    public Renderer rend;
    public Material emission;
    public GameObject starSur;
    public starSurface corona;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        emission = GetComponent<Renderer>().material;
        rend.material.color = starColor;
        corona = starSur.GetComponent<starSurface>();
    }

    // Update is called once per frame
    void Update()
    {
        if (corona.starSurSize == 0.05)
        {
            emission.SetColor("_EmissionColor", Color.black);
            starColor.r += 0.25f * Time.deltaTime;
            starColor.b -= 0.5f * Time.deltaTime;
            starColor.g -= 0.5f * Time.deltaTime;
            rend.material.color = starColor;
        }

        if (corona.starSurSize == 0.1)
        {
            enabled = false;
            Destroy(gameObject);
        }
    }
}
