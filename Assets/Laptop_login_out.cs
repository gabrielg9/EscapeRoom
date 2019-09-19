using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Laptop_login_out : MonoBehaviour
{
    string[] maskArray = new string[10];
    int maskIndex = 0;
    public InputField PasswordInput;
    public Text MaskOutput;
    public GameObject textDisplay;


    private void Start()
    {
        maskArray[0] = "";
        string mask = "";
        for(int i=1; i<10; i++)
        {
            maskArray[i] = mask + "*";
            mask = mask + "*";
        }
    }
    public void MaskPassword()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            maskIndex--;
            if (maskIndex == -1)
                maskIndex = 0;
            MaskOutput.text = maskArray[maskIndex];
        }
        else
        {
            maskIndex++;
            if (maskIndex == 10)
                maskIndex = 9;
            MaskOutput.text = maskArray[maskIndex];
        }
    }
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
        //Debug.Log(PasswordInput.text);
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(PasswordInput.text);
            if(PasswordInput.text == password)
            {
                Debug.Log("haslo poprawne");
            }
            else
            {
                Debug.Log("haslo niepoprawne");
                maskIndex = 0;
                MaskOutput.text = maskArray[maskIndex];
                textDisplay.GetComponent<Text>().text = "The password is incorrect. Try again";
            }
        }
        if (Input.GetMouseButton(0))
            textDisplay.GetComponent<Text>().text = "";
    }
}
