using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superNovaBehaviour : MonoBehaviour
{
    public GameObject energyExplode;
    public GameObject starSurface;
    public GameObject deadStar;
    public starSurfaceBehaviour getStarSurface;

    // Start is called before the first frame update
    void Start()
    {
        getStarSurface = starSurface.GetComponent<starSurfaceBehaviour>();
        energyExplode.SetActive(false);
        deadStar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (getStarSurface.starSurfaceSize == 0.3)
        {
            energyExplode.SetActive(true);
            deadStar.SetActive(true);
        }
        
    }
}
