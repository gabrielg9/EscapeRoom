using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public bool onTrigger;
    public bool listened = false;
    private AudioSource audioClip;
    private bool popup = false;
    
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
                popup = true;
                audioClip = gameObject.GetComponent<AudioSource>();
                audioClip.Play();
                listened = true;
            }
        }
        else
        {
            popup = false;
            //audioClip.Stop();
        }
            
    }

    private void OnGUI()
    {
        if (popup)
        {
            GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 15, 400, 30), "Upewnij się, że masz włączone głośniki lub podpięte słuchawki");
        }

    }
}
