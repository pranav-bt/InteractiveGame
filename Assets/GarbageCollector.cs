using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    public GameObject PauseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Hazard")
        {
            Destroy(collision.gameObject);
            Time.timeScale = 0;
            PauseCanvas.SetActive(true);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
