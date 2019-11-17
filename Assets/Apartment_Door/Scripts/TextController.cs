using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    public static int iterator = 0;

    // Start is called before the first frame update
    void Start()
    {
        LoadDescription();
        iterator++;
    }

    public void LoadDescription()
    {
        if(iterator == 0)
            Destroy(gameObject, 4.0f);
        else
            Destroy(gameObject, 0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        /*if (PlayerPrefs.GetString("finished") == "MobileScene")
            Destroy(gameObject, 0.0f);
        else if (PlayerPrefs.GetString("finished") == "BookScene")
            Destroy(gameObject, 0.0f);
        else if (PlayerPrefs.GetString("finished") == "CrosswordScene")
            Destroy(gameObject, 0.0f);
        else if (PlayerPrefs.GetString("finished") == "LaptopScene")
            Destroy(gameObject, 0.0f);
        else
            Destroy(gameObject, 4.0f);*/
    }
}
