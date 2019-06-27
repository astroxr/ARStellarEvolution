using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeScene : MonoBehaviour
{

    // Update is called once per frame
    public void ChangeToScene(int sceneToChangeTo)
    {
        Application.LoadLevel(sceneToChangeTo);
    }
}
