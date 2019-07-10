using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superNovaBehaviour : MonoBehaviour
{
    public GameObject starSurface, deadStar, ember, explodeDust0;
    public starSurfaceBehaviour getStarSurface;

    // Start is called before the first frame update
    void Start()
    {
        getStarSurface = starSurface.GetComponent<starSurfaceBehaviour>();
        explodeDust0.SetActive(false);
        ember.SetActive(false);
        deadStar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (getStarSurface.starSurfaceSize == 0.3)
        {
            explodeDust0.SetActive(true);
            ember.SetActive(true);
            deadStar.SetActive(true);
        }
        
    }
}
