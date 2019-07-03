using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controlStarPage : MonoBehaviour
{
    public TextMeshProUGUI phaseIndicator;
    public Slider phaseSlider;

    public void Start()
    {
        if (phaseSlider != null)
        {
            phaseSlider.value = PlayerPrefs.GetFloat("LatestSliderVal", 0);
        }
    }

    public void SeeARPhase()
    {
        PlayerPrefs.SetFloat("LatestSliderVal", phaseSlider.value);

        if (phaseIndicator.text == "Phase 1: Stellar Nebula")
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            if (sceneIndex == 1)
            {
                SceneManager.LoadScene(5);
            }
            else
            {
                SceneManager.LoadScene(13);
            }

        }
        else if (phaseIndicator.text == "Phase 2: Average Star")
        {
            SceneManager.LoadScene(6);
        }
        else if (phaseIndicator.text == "Phase 2: Massive Star")
        {
            SceneManager.LoadScene(10);
        }
        else if (phaseIndicator.text == "Phase 3: Red Giant")
        {
            SceneManager.LoadScene(7);
        }
        else if (phaseIndicator.text == "Phase 3: Red Super Giant")
        {
            SceneManager.LoadScene(11);
        }
        else if (phaseIndicator.text == "Phase 4: Planetary Nebula")
        {
            SceneManager.LoadScene(8);
        }
        else if (phaseIndicator.text == "Phase 4: Supernova")
        {
            SceneManager.LoadScene(14);
        }
        else if (phaseIndicator.text == "Phase 5: White Dwarf")
        {
            SceneManager.LoadScene(9);
        }
        else if (phaseIndicator.text == "Phase 5: Neutron Star / Black Hole")
        {
            SceneManager.LoadScene(12);
        }
    }

    public void SeeLifeCycle(int sceneToChangeTo)
    {
        PlayerPrefs.SetFloat("LatestSliderVal", phaseSlider.value);

        SceneManager.LoadScene(sceneToChangeTo);
    }

    public void GoToHome(int sceneToChangeTo)
    {
        PlayerPrefs.SetFloat("LatestSliderVal", 0);
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
