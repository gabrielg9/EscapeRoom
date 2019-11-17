using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Crossword : MonoBehaviour
{
    public static int iterator = 0;

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

    private string input1, input2, input3, input4, input5;
    private string output1, output2, output3, output4, output5;

    private char[] array1, array2, array3, array4, array5;

    public GameObject[] Placeholder1, Placeholder2, Placeholder3, Placeholder4, Placeholder5;


    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    public void Load()
    {
         if(iterator != 0)
         { 
            Debug.Log("zczytanie");
            output1 = PlayerPrefs.GetString("name1");
            output2 = PlayerPrefs.GetString("name2");
            output3 = PlayerPrefs.GetString("name3");
            output4 = PlayerPrefs.GetString("name4");
            output5 = PlayerPrefs.GetString("name5");

            array1 = output1.ToCharArray();
            array2 = output2.ToCharArray();
            array3 = output3.ToCharArray();
            array4 = output4.ToCharArray();
            array5 = output5.ToCharArray();

            for (int i = 0; i < array1.Length; i++)
                Placeholder1[i].GetComponent<Text>().text = array1[i].ToString();
            for (int i = 0; i < array2.Length; i++)
                Placeholder2[i].GetComponent<Text>().text = array2[i].ToString();
            for (int i = 0; i < array3.Length; i++)
                Placeholder3[i].GetComponent<Text>().text = array3[i].ToString();
            for (int i = 0; i < array4.Length; i++)
                Placeholder4[i].GetComponent<Text>().text = array4[i].ToString();
            for (int i = 0; i < array5.Length; i++)
                Placeholder5[i].GetComponent<Text>().text = array5[i].ToString();
        }
    }

    public void StoreName()
    {
        iterator++;

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

        for (int i = 0; i < s1.Length; i++)
            input1 += s1[i];
        for (int i = 0; i < s2.Length; i++)
            input2 += s2[i];
        for (int i = 0; i < s3.Length; i++)
            input3 += s3[i];
        for (int i = 0; i < s4.Length; i++)
            input4 += s4[i];
        for (int i = 0; i < s5.Length; i++)
            input5 += s5[i];

        PlayerPrefs.SetString("name1", input1);
        PlayerPrefs.SetString("name2", input2);
        PlayerPrefs.SetString("name3", input3);
        PlayerPrefs.SetString("name4", input4);
        PlayerPrefs.SetString("name5", input5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 220, 25), "Naciśnij 'Esc' by wrócić do pokoju");
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("EscapeRoom");
    }
}
