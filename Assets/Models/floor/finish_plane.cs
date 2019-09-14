using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish_plane : MonoBehaviour
{
    public bool onTrigger;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        SceneManager.LoadScene("End_Game");
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }
}
