using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goToHome : MonoBehaviour
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
        PlayerPrefs.SetFloat("LatestSliderVal", 0);
        SceneManager.LoadScene(sceneToChangeTo);
    }
}
