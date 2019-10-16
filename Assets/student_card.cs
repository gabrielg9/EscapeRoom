using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class student_card : MonoBehaviour
{
    public bool onTrigger;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(onTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Camera.main.fieldOfView = 30.0f;
            }
        }
        else
        {
            Camera.main.fieldOfView = 60.0f;
        }
    }
}
