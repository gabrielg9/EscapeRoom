using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laptop_login_out : MonoBehaviour
{
    private string password = "WIMIIP";

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 200, 25), "Press 'Esc' to return to room");
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("EscapeRoom");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
