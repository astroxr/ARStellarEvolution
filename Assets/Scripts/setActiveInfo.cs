using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class setActiveInfo : MonoBehaviour
{
    public Image imageInfo;
    public TextMeshProUGUI textInfo;

    public void Start()
    {
        imageInfo.enabled = false;
        textInfo.enabled = false;
    }

    public void CheckInfoActive()
    {
        if (!imageInfo.enabled)
        {
            SetOnClick();
        }
        else
        {
            RemoveOnClick();
        }
    }

    public void SetOnClick()
    {
        imageInfo.enabled = true;
        textInfo.enabled = true;
    }

    public void RemoveOnClick()
    {
        imageInfo.enabled = false;
        textInfo.enabled = false;
    }
}
