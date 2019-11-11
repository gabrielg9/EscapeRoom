using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Book_out : MonoBehaviour
{

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 220, 25), "Naciśnij 'Esc' by wrócić do pokoju");
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("EscapeRoom");
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("finished", "BookScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
