using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class prevPhaseMass : MonoBehaviour
{
    public TextMeshProUGUI phaseNumberMass2;
    public TextMeshProUGUI phaseInfoMass2;

    // Update is called once per frame
    public void changeToPrevTextMass()
    {
        if (phaseNumberMass2.text == "Phase 5: Black Hole")
        {
            phaseNumberMass2.text = "Phase 4: Supernova";
            phaseInfoMass2.text = "The star expand so much that its outer " +
                "atmosphere drifted out from the star in a process called " +
                "supernova explosion.";
        }

        else if (phaseNumberMass2.text == "Phase 4: Supernova")
        {
            phaseNumberMass2.text = "Phase 3: Red Super Giant";
            phaseInfoMass2.text = "After the star has run out of hydrogen, " +
                "it will lose its hydrostatic equilibrium and it is going to " +
                "collapse again until the heliums themselves will be used as " +
                "an energy source, which will then expand the star even more.";
        }

        else if (phaseNumberMass2.text == "Phase 3: Red Super Giant")
        {
            phaseNumberMass2.text = "Phase 2: Massive Star";
            phaseInfoMass2.text = "The dust and gases are attracted to each other " +
                "by their own gravity and getting denser and hotter until " +
                "they fused together form a star.";
        }

        else if (phaseNumberMass2.text == "Phase 2: Massive Star")
        {
            phaseNumberMass2.text = "Phase 1: Stellar Nebula";
            phaseInfoMass2.text = "Huge clouds of dust and gases exist in space.";
        }

    }
}
