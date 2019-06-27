using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superNova2 : MonoBehaviour
{
    public GameObject energyExplode;
    public GameObject aveStarSurface;
    public GameObject deadStar;
    public aveStarSur getAveStarSurface;

    // Start is called before the first frame update
    void Start()
    {
        getAveStarSurface = aveStarSurface.GetComponent<aveStarSur>();
        energyExplode.SetActive(false);
        deadStar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (getAveStarSurface.aveStarSurfaceSize == 0.3)
        {
            energyExplode.SetActive(true);
            deadStar.SetActive(true);
        }

    }
}
