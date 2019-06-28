using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class changeNextPhase : MonoBehaviour
{
    public TextMeshProUGUI phaseNumber;
    public TextMeshProUGUI phaseInfo;
    public Image phaseImage;
    public Slider phaseSlider;
    public Sprite nebulacloud;
    public Sprite lowmassstar;
    public Sprite redgiant;
    public Sprite whitedwarf;


    public void changeToNextText()
    {
        if (phaseNumber.text == "Phase 1: Stellar Nebula")
        {
            phaseNumber.text = "Phase 2: Average Star";
            phaseInfo.text = "The dust and gases are attracted to each other " +
                "by their own gravity and getting denser and hotter until " +
                "they fused together form a star.";
            phaseImage.sprite = lowmassstar;
            phaseSlider.value = 1;
        }

        else if (phaseNumber.text == "Phase 2: Average Star")
        {
            phaseNumber.text = "Phase 3: Red Giant";
            phaseInfo.text = "After the star has run out of hydrogen, " +
                "it will lose its hydrostatic equilibrium and it is going to " +
                "collapse again until the heliums themselves will be used as " +
                "an energy source, which will then expand the star even more.";
            phaseImage.sprite = redgiant;
            phaseSlider.value = 2;
        }

        else if (phaseNumber.text == "Phase 3: Red Giant")
        {
            phaseNumber.text = "Phase 4: Supernova";
            phaseInfo.text = "The star expand so much that its outer " +
                "atmosphere drifted out from the star in a process called " +
                "supernova explosion.";
            phaseImage.sprite = nebulacloud;
            phaseSlider.value = 3;
        }

        else if (phaseNumber.text == "Phase 4: Supernova")
        {
            phaseNumber.text = "Phase 5: White Dwarf";
            phaseInfo.text = "The remnants of the average star is the white " +
                "dwarf, which is the core of the star. It is incredibly " +
                "dense and hot.";
            phaseImage.sprite = whitedwarf;
            phaseSlider.value = 4;
        }

    }
}
