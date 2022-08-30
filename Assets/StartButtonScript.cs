using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StartButton;
    private void Start()
    {
        Time.timeScale = 0;
    }
    public void OnStartButton()
    {
        StartButton.SetActive(false);
        Time.timeScale = 1;
    }
}
