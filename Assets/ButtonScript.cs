using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject PauseCanvas;
    public void OnContinueButtonPress()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
}
