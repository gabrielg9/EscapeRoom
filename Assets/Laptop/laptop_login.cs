using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laptop_login : MonoBehaviour
{
    public bool onTrigger;
    public GameObject FPSController;
    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }

    


    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                FPSController.GetComponent<SavingPosition>().Save();
                SceneManager.LoadScene("Laptop_monitor");
            }
        }
    }
}
