using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class changePrevPhase : MonoBehaviour
{

    public TextMeshProUGUI phaseNumber2;
    public TextMeshProUGUI phaseInfo2;
    public Image phaseImage2;
    public Slider phaseSlider2;
    public Sprite nebulacloud;
    public Sprite lowmassstar;
    public Sprite redgiant;
    public Sprite whitedwarf;

    // Update is called once per frame
    public void changeToPrevText()
    {
        if (phaseNumber2.text == "Phase 5: White Dwarf")
        {
            phaseNumber2.text = "Phase 4: Supernova";
            phaseInfo2.text = "The star expand so much that its outer " +
                "atmosphere drifted out from the star in a process called " +
                "supernova explosion.";
            phaseImage2.sprite = nebulacloud;
            phaseSlider2.value = 3;
        }

        else if (phaseNumber2.text == "Phase 4: Supernova")
        {
            phaseNumber2.text = "Phase 3: Red Giant";
            phaseInfo2.text = "After the star has run out of hydrogen, " +
                "it will lose its hydrostatic equilibrium and it is going to " +
                "collapse again until the heliums themselves will be used as " +
                "an energy source, which will then expand the star even more.";
            phaseImage2.sprite = redgiant;
            phaseSlider2.value = 2;
        }

        else if (phaseNumber2.text == "Phase 3: Red Giant")
        {
            phaseNumber2.text = "Phase 2: Average Star";
            phaseInfo2.text = "The dust and gases are attracted to each other " +
                "by their own gravity and getting denser and hotter until " +
                "they fused together form a star.";
            phaseImage2.sprite = lowmassstar;
            phaseSlider2.value = 1;
        }

        else if (phaseNumber2.text == "Phase 2: Average Star")
        {
            phaseNumber2.text = "Phase 1: Stellar Nebula";
            phaseInfo2.text = "Huge clouds of dust and gases exist in space.";
            phaseImage2.sprite = nebulacloud;
            phaseSlider2.value = 0;
        }

    }
}
