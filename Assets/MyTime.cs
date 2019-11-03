using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTime : MonoBehaviour
{
    private float allTime;
    public static float realtimeSinceStartup;
    public Text timerText;
    private string textString;
    int hours, minutes, seconds;
    void Start()
    {
        allTime = Time.realtimeSinceStartup;
        seconds = (int)(allTime % 60);
        minutes = (int)(allTime / 60) % 60;
        hours = (int)(allTime / 3600) % 24;
    }

    void Update()
    {
        textString = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);
        timerText.text = "Twój czas wydostania się z pokoju to " + textString;
    }
}
