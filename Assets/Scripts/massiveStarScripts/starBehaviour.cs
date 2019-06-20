using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starBehaviour : MonoBehaviour
{
    public GameObject starSurface;
    public starSurfaceBehaviour getStarSurface;
    public Renderer rend;
    public Color starColor;

    // Start is called before the first frame update
    void Start()
    {
        getStarSurface = starSurface.GetComponent<starSurfaceBehaviour>();
        rend = GetComponent<Renderer>();
        starColor = new Color(0.05409207f, 0.04917233f, 0.8018868f);
    }

    // Update is called once per frame
    void Update()
    {
        if (getStarSurface.starSurfaceSize > 0.1)
        {
            starColor.r += 0.08f * Time.deltaTime;
            starColor.b -= 0.25f * Time.deltaTime;
            rend.material.SetColor("_EmissionColor", starColor);
        }
    }
}
