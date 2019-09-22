using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mobile_out : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 200, 25), "Press 'Esc' to return to room");
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("EscapeRoom");
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
