using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSmartphoneScene : MonoBehaviour
{
    private bool phone = false;
    public bool onTrigger;
    public GameObject FPSController;
    public static int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
                counter++;
        }
        else
            counter = 0;
            
        if(counter >= 1)
        {
            FPSController.GetComponent<SavingPosition>().Save();
        }
    }
}
