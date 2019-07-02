using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pressLifeCycleAR : MonoBehaviour
{
    public Slider phaseSlider;

    public void Start()
    {
        if (phaseSlider != null)
        {
            phaseSlider.value = PlayerPrefs.GetFloat("LatestSliderVal", 0);
        }
    }

    public void ChangeToScene(int sceneToChangeTo)
    {
        PlayerPrefs.SetFloat("LatestSliderVal", phaseSlider.value);

        SceneManager.LoadScene(sceneToChangeTo);
    }
}
