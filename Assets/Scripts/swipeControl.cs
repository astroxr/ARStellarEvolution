using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class swipeControl : MonoBehaviour
{
    public Vector2 startTouch, endTouch;
    public float swipeLength = 100; 
    public float swipeRead;
    public Slider phaseSlider;

    public void Start()
    {
        if (phaseSlider != null)
        {
            phaseSlider.value = PlayerPrefs.GetFloat("LatestSliderVal",0);
        }
    }

    public void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouch = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouch = Input.GetTouch(0).position;
            swipeRead = endTouch.x - startTouch.x;

            if(swipeRead > swipeLength && startTouch.x < 150)
            {
                PlayerPrefs.SetFloat("LatestSliderVal", 0);
                SceneManager.LoadScene(0);
            }
            else
            {
                Reset();
            }
        }
    }

    public void Reset()
    {
        startTouch = Vector2.zero;
        endTouch = Vector2.zero;
    }
}
