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
    public Image desktop_image;
    public Text textImage;
    


    private void Start()
    {
        maskArray[0] = "";
        string mask = "";
        for(int i=1; i<10; i++)
        {
            maskArray[i] = mask + "*";
            mask = mask + "*";
        }
        desktop_image.enabled = false;
        textImage.enabled = false;
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
        GUI.Box(new Rect(0, 0, 220, 25), "Naciśnij 'Esc' by wrócić do pokoju");
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
                desktop_image.enabled = true;
                textImage.enabled = true;
            }
            else
            {
                Debug.Log("haslo niepoprawne");
                maskIndex = 0;
                MaskOutput.text = maskArray[maskIndex];
                textDisplay.GetComponent<Text>().text = "Hasło nieprawidłowe. Spróbuj ponownie";
            }
        }
        if (Input.GetMouseButton(0))
            textDisplay.GetComponent<Text>().text = "";
    }
}
