using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class openARScene : MonoBehaviour
{
    public TextMeshProUGUI phaseIndicator;

    public void SeeARPhase()
    {
        if (phaseIndicator.text == "Phase 1: Stellar Nebula")
        {
            Application.LoadLevel(5);
        }
        else if (phaseIndicator.text == "Phase 2: Average Star")
        {
            Application.LoadLevel(6);
        }
        else if (phaseIndicator.text == "Phase 2: Massive Star")
        {
            Application.LoadLevel(10);
        }
        else if (phaseIndicator.text == "Phase 3: Red Giant")
        {
            Application.LoadLevel(7);
        }
        else if (phaseIndicator.text == "Phase 3: Red Super Giant")
        {
            Application.LoadLevel(11);
        }
        else if (phaseIndicator.text == "Phase 4: Supernova")
        {
            Application.LoadLevel(8);
        }
        else if (phaseIndicator.text == "Phase 5: White Dwarf")
        {
            Application.LoadLevel(9);
        }
        else if (phaseIndicator.text == "Phase 5: Black Hole")
        {
            Application.LoadLevel(12);
        }
    }
}
