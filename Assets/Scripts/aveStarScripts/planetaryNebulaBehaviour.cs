using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetaryNebulaBehaviour : MonoBehaviour
{
    public GameObject aveStarSurface, deadStar, planetaryNebula0,
    planetaryNebula1, planetaryNebula2, planetaryNebula3, planetaryNebula4,
    planetaryNebula5, planetaryNebula6, outerAtmosphere, outerAtmosphereCorona;
    public aveStarSur getAveStarSurface;

    void Start()
    {
        getAveStarSurface = aveStarSurface.GetComponent<aveStarSur>();
        deadStar.SetActive(false);
    }

    void Update()
    {
        if (getAveStarSurface.aveStarSurfaceSize == 0.3)
        {
            deadStar.SetActive(true);

            if (planetaryNebula0.transform.localScale.x < 0.15)
            {
                planetaryNebula0.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
                planetaryNebula1.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
                planetaryNebula2.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
                planetaryNebula3.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
                planetaryNebula4.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
                planetaryNebula5.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
                planetaryNebula6.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);

                outerAtmosphere.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
                outerAtmosphereCorona.transform.localScale += new Vector3(2f * Time.deltaTime,
                2f * Time.deltaTime, 2f * Time.deltaTime);
            }
            else
            {
                planetaryNebula0.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
                planetaryNebula1.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
                planetaryNebula2.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
                planetaryNebula3.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
                planetaryNebula4.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
                planetaryNebula5.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
                planetaryNebula6.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);

                outerAtmosphere.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
                outerAtmosphereCorona.transform.localScale += new Vector3(0.07f * Time.deltaTime,
                0.07f * Time.deltaTime, 0.07f * Time.deltaTime);
            }
            if (planetaryNebula0.transform.localScale.x > 0.7)
            {
                Destroy(planetaryNebula0);
                Destroy(outerAtmosphere);
                enabled = false;
            }


        }
    }
}
