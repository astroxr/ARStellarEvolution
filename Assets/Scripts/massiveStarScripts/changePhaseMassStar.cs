using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class changePhaseMassStar : MonoBehaviour
{
    public TextMeshProUGUI phaseNumberMass;
    public TextMeshProUGUI phaseInfoMass;
    public Image phaseImageMass, phaseImageMass2;
    public Slider phaseSliderMass;
    public Sprite nebulacloud, massivestar, redsupergiant, supernova,
    neutronstar, blackhole;

    public void Start()
    {
        phaseImageMass2.enabled = false;
        if(phaseImageMass.sprite == neutronstar)
        {
            phaseImageMass2.enabled = true;
        }
    }

    public void ChangeToNextTextMass()
    {
        if (phaseNumberMass.text == "Phase 1: Stellar Nebula")
        {
            phaseSliderMass.value = 1;
        }

        else if (phaseNumberMass.text == "Phase 2: Massive Star")
        {
            phaseSliderMass.value = 2;
        }

        else if (phaseNumberMass.text == "Phase 3: Red Super Giant")
        {
            phaseSliderMass.value = 3;
        }

        else if (phaseNumberMass.text == "Phase 4: Supernova")
        {
            phaseSliderMass.value = 4;
        }

    }

    public void ChangeToPrevTextMass()
    {
        if (phaseNumberMass.text == "Phase 5: Neutron Star / Black Hole")
        {
            phaseSliderMass.value = 3;
        }

        else if (phaseNumberMass.text == "Phase 4: Supernova")
        {
            phaseSliderMass.value = 2;
        }

        else if (phaseNumberMass.text == "Phase 3: Red Super Giant")
        {
            phaseSliderMass.value = 1;
        }

        else if (phaseNumberMass.text == "Phase 2: Massive Star")
        {
            phaseSliderMass.value = 0;
        }

    }

    public void ControlSliderMass()
    {
        if(phaseSliderMass.value == 0)
        {
            phaseNumberMass.text = "Phase 1: Stellar Nebula";
            phaseInfoMass.text = "Huge clouds of hydrogen gas and dust exist" +
                " in space.The existing stars that are formed within it" +
                " energised the gas in the stellar nebula making it glows" +
                " brightly in space.";
            phaseImageMass.transform.localPosition = new Vector3(0, -394, 0);
            phaseImageMass.sprite = nebulacloud;
            phaseImageMass2.enabled = false;
        }
        if (phaseSliderMass.value == 1)
        {
            phaseNumberMass.text = "Phase 2: Massive Star";
            phaseInfoMass.text = "The gases are so huge that they " +
                "attracted to each other by their own gravity and got " +
                "denser until they fused together and formed a star." +
                " If the combined mass of the gases are above eight" +
                " solar masses, it will form a massive star. In this phase," +
                " hydrogens are fused into heliums in a process called nuclear" +
                " fussion where it produces heat energy and light.";
            phaseImageMass.transform.localPosition = new Vector3(0, -394, 0);
            phaseImageMass.sprite = massivestar;
            phaseImageMass2.enabled = false;
        }
        if (phaseSliderMass.value == 2)
        {
            phaseNumberMass.text = "Phase 3: Red Super Giant";
            phaseInfoMass.text = "After the star has run out of hydrogen, " +
                "it will lose its inner gas pressure (that it gets from" +
                " nuclear fussion reaction) and it is going to " +
                "collapse inward due to its own gravity until the" +
                " heliums fused into carbons which will then produced" +
                " more energy and expand the star even more to " +
                "form a red super giant.";
            phaseImageMass.transform.localPosition = new Vector3(0, -394, 0);
            phaseImageMass.sprite = redsupergiant;
            phaseImageMass2.enabled = false;
        }
        if (phaseSliderMass.value == 3)
        {
            phaseNumberMass.text = "Phase 4: Supernova";
            phaseInfoMass.text = "The star contains so much energy that" +
            	" it eventually explodes. This process is called supernova" +
            	" explosion. This explosion happens in a very short period" +
            	" of time and it is brighter than 100 million suns.";
            phaseImageMass.transform.localPosition = new Vector3(0, -394, 0);
            phaseImageMass.sprite = supernova;
            phaseImageMass2.enabled = false;
        }
        if (phaseSliderMass.value == 4)
        {
            phaseNumberMass.text = "Phase 5: Neutron Star / Black Hole";
            phaseInfoMass.text = "Supernova explosion caused the existing" +
            	" protons and electrons from the star to fused together" +
            	" and stabilized only by the neutron degenaracy pressure." +
            	" This will result in the forming of neuron star, which has" +
            	" a mass of three times solar mass with only 20km in" +
            	" diameter. Denser neutron stars will collapse into" +
            	" itself and form a black hole.";
            phaseImageMass.sprite = neutronstar;
            phaseImageMass2.enabled = true;
            phaseImageMass.transform.localPosition = new Vector3(-271, -394, 0);
        }
    }
}
