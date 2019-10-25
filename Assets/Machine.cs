using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public bool streched = false;
    public Canvas canvas;
    
    void Start()
    {
        //canvas.enabled = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if(streched)
        {
            canvas.enabled = true;
        }
    }
}
