using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aveStar : MonoBehaviour
{
    public GameObject aveStarSurface;
    public aveStarSur getAveStarSurface;
    public Renderer rend;
    public Color aveStarColor;

    // Start is called before the first frame update
    void Start()
    {
        getAveStarSurface = aveStarSurface.GetComponent<aveStarSur>();
        rend = GetComponent<Renderer>();
        aveStarColor = new Color(0.8490566f, 0.3561321f, 0.06007475f);
    }

    // Update is called once per frame
    void Update()
    {
        if (getAveStarSurface.aveStarSurfaceSize > 0.15f)
        {
            if(aveStarColor.r > 0.6431373f)
            {
                aveStarColor.r -= 0.1f * Time.deltaTime;
            }
            if(aveStarColor.g > 0.09716064)
            {
                aveStarColor.g -= 0.1f * Time.deltaTime;
            }
            rend.material.SetColor("_EmissionColor", aveStarColor);
        }
    }
}
