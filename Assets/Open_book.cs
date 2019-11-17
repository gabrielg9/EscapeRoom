using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_book : MonoBehaviour
{
    public bool onTrigger;
    public GameObject FPSController;
    private void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }

    
    
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FPSController.GetComponent<SavingPosition>().Save();
                SceneManager.LoadScene("Book_on_table");
            }
        }
    }
}
