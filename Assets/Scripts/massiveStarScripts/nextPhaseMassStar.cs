using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class nextPhaseMassStar : MonoBehaviour
{
    public TextMeshProUGUI phaseNumberMass;
    public TextMeshProUGUI phaseInfoMass;
    public Image phaseImageMass;
    public Slider phaseSliderMass;
    public Sprite nebulacloud;
    public Sprite massivestar;
    public Sprite redsupergiant;
    public Sprite blackhole;

    public void changeToNextTextMass()
    {
        if (phaseNumberMass.text == "Phase 1: Stellar Nebula")
        {
            phaseNumberMass.text = "Phase 2: Massive Star";
            phaseInfoMass.text = "The dust and gases are attracted to each other " +
                "by their own gravity and getting denser and hotter until " +
                "they fused together form a star.";
            phaseImageMass.sprite = massivestar;
            phaseSliderMass.value = 1;
        }

        else if (phaseNumberMass.text == "Phase 2: Massive Star")
        {
            phaseNumberMass.text = "Phase 3: Red Super Giant";
            phaseInfoMass.text = "After the star has run out of hydrogen, " +
                "it will lose its hydrostatic equilibrium and it is going to " +
                "collapse again until the heliums themselves will be used as " +
                "an energy source, which will then expand the star even more.";
            phaseImageMass.sprite = redsupergiant;
            phaseSliderMass.value = 2;
        }

        else if (phaseNumberMass.text == "Phase 3: Red Super Giant")
        {
            phaseNumberMass.text = "Phase 4: Supernova";
            phaseInfoMass.text = "The star expand so much that its outer " +
                "atmosphere drifted out from the star in a process called " +
                "supernova explosion.";
            phaseImageMass.sprite = nebulacloud;
            phaseSliderMass.value = 3;
        }

        else if (phaseNumberMass.text == "Phase 4: Supernova")
        {
            phaseNumberMass.text = "Phase 5: Black Hole";
            phaseInfoMass.text = "The remnants of the massive star is the " +
                "black hole, which is the core of the star. It is incredibly " +
                "dense and hot.";
            phaseImageMass.sprite = blackhole;
            phaseSliderMass.value = 4;
        }

    }
}
