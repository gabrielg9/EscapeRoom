using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Crossword : MonoBehaviour
{
    public GameObject[] iField1;
    private string[] s1 = new string[10];
    public GameObject[] iField2;
    private string[] s2 = new string[10];
    public GameObject[] iField3;
    private string[] s3 = new string[13];
    public GameObject[] iField4;
    private string[] s4 = new string[4];
    public GameObject[] iField5;
    private string[] s5 = new string[9];
    public GameObject[] password;
    private string[] passwordString = new string[15];

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("finished", "CrosswordScene");
        
    }

    void StoreName()
    {
        for (int i = 0; i < 10; i++)
            s1[i] = iField1[i].GetComponent<Text>().text;
        for (int i = 0; i < 10; i++)
            s2[i] = iField2[i].GetComponent<Text>().text;
        for (int i = 0; i < 13; i++)
            s3[i] = iField3[i].GetComponent<Text>().text;
        for (int i = 0; i < 4; i++)
            s4[i] = iField4[i].GetComponent<Text>().text;
        for (int i = 0; i < 9; i++)
            s5[i] = iField5[i].GetComponent<Text>().text;

        password[0].GetComponent<Text>().text = s4[0];
        password[1].GetComponent<Text>().text = s2[6];
        password[2].GetComponent<Text>().text = s5[3];
        //password[3].GetComponent<Text>().text = s4[0];
        password[4].GetComponent<Text>().text = s3[11];
        password[5].GetComponent<Text>().text = s2[3];
        password[6].GetComponent<Text>().text = s2[8];
        password[7].GetComponent<Text>().text = s4[2];
        password[8].GetComponent<Text>().text = s3[10];
        password[9].GetComponent<Text>().text = s3[11];
        password[10].GetComponent<Text>().text = s3[12];
        password[11].GetComponent<Text>().text = s5[6];
        password[12].GetComponent<Text>().text = s1[3];
        password[13].GetComponent<Text>().text = s1[7];
        password[14].GetComponent<Text>().text = s1[6];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            StoreName();
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 220, 25), "Naciśnij 'Esc' by wrócić do pokoju");
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("EscapeRoom");
    }
}
