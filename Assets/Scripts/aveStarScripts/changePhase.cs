using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class changePhase : MonoBehaviour
{
    public TextMeshProUGUI phaseNumber;
    public TextMeshProUGUI phaseInfo;
    public Image phaseImage;
    public Slider phaseSlider;
    public Sprite nebulacloud;
    public Sprite lowmassstar;
    public Sprite redgiant;
    public Sprite whitedwarf;


    public void ChangeToNextText()
    {
        if (phaseNumber.text == "Phase 1: Stellar Nebula")
        {
            phaseSlider.value = 1;
        }

        else if (phaseNumber.text == "Phase 2: Average Star")
        {
            phaseSlider.value = 2;
        }

        else if (phaseNumber.text == "Phase 3: Red Giant")
        {
            phaseSlider.value = 3;
        }

        else if (phaseNumber.text == "Phase 4: Planetary Nebula")
        {
            phaseSlider.value = 4;
        }

    }

    public void ChangeToPrevText()
    {
        if (phaseNumber.text == "Phase 5: White Dwarf")
        {
            phaseSlider.value = 3;
        }

        else if (phaseNumber.text == "Phase 4: Planetary Nebula")
        {
            phaseSlider.value = 2;
        }

        else if (phaseNumber.text == "Phase 3: Red Giant")
        {
            phaseSlider.value = 1;
        }

        else if (phaseNumber.text == "Phase 2: Average Star")
        {
            phaseSlider.value = 0;
        }

    }

    public void ControlSlider()
    {
        if (phaseSlider.value == 0)
        {
            phaseNumber.text = "Phase 1: Stellar Nebula";
            phaseInfo.text = "Huge clouds of hydrogen gas and dust exist" +
            	" in space.The existing stars that are formed within it" +
            	" energised the gas in the stellar nebula making it glows" +
            	" brightly in space.";
           phaseImage.sprite = nebulacloud;
        }
        else if (phaseSlider.value == 1)
        {
            phaseNumber.text = "Phase 2: Average Star";
            phaseInfo.text = "The gases are so huge that they " +
                "attracted to each other by their own gravity and got " +
                "denser until they fused together and formed a star." +
                " If the combined mass of the gases are below eight" +
                " solar masses, it will form an average star.In this phase," +
                " hydrogen is fused into helium in a process called nuclear" +
                " fussion where it produces heat energy and light.";
            phaseImage.sprite = lowmassstar;
        }
        else if (phaseSlider.value == 2)
        {
            phaseNumber.text = "Phase 3: Red Giant";
            phaseInfo.text = "After the star has run out of hydrogen, " +
                "it will lose its inner gas pressure (that it gets from" +
                " nuclear fussion reaction) and it is going to " +
                "collapse inward due to its own gravity until the heliums" +
                " inside the star will started to fused with each other and" +
                " produced more energy and expand the star even more to " +
                "form a red giant.";
            phaseImage.sprite = redgiant;
        }
        else if (phaseSlider.value == 3)
        {
            phaseNumber.text = "Phase 4: Planetary Nebula";
            phaseInfo.text = "The star expand so much that its outer " +
                "atmosphere drifted out from the star and formed" +
                " a planetary nebula.";
            phaseImage.sprite = nebulacloud;
        }
        else if (phaseSlider.value == 4)
        {
            phaseNumber.text = "Phase 5: White Dwarf";
            phaseInfo.text = "After the outer atmosphere has drifted out" +
                " to space, the remnants of it is the white " +
                "dwarf, which is the core of the star. It is incredibly " +
                "dense and hot. Its mass is about the mass of the sun with only" +
                "the size about the size of the earth.";
            phaseImage.sprite = whitedwarf;
        }
    }
}
