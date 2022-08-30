using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject Bullet;
    public float FireRate = 5.0f;
    private float CurrentTime = 0.0f;
    private float TimeElapsed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        TimeElapsed += Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftControl) && (TimeElapsed - CurrentTime > FireRate))
        {

            GameObject NewBullet = Instantiate(Bullet) as GameObject;
            NewBullet.transform.position = gameObject.transform.position;
            CurrentTime = TimeElapsed;
        }
    }
}
