using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public bool onTrigger;
    private AudioSource audioClip;
    
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

        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                audioClip = gameObject.GetComponent<AudioSource>();
                audioClip.Play();
            }
        }
    }
}
