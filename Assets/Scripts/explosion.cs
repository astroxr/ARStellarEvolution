using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    public GameObject energyExplosion, dustExplosion, star, blackHole;
    public starSurface redGiant;
    public bool hasExploded;

    // Start is called before the first frame update
    void Start()
    {
        hasExploded = false;
        redGiant = star.GetComponent<starSurface>();
        blackHole.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (redGiant.starSurSize == 0.1 && !hasExploded)
        {
            Instantiate(energyExplosion, transform.position, transform.rotation);
            Instantiate(dustExplosion, transform.position, transform.rotation);
            hasExploded = true;
            blackHole.SetActive(true);
        }
    }
}
