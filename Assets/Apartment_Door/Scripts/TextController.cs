using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("finished") == "MobileScene")
            Destroy(gameObject, 0.0f);
        else if (PlayerPrefs.GetString("finished") == "BookScene")
            Destroy(gameObject, 0.0f);
        else if (PlayerPrefs.GetString("finished") == "CrosswordScene")
            Destroy(gameObject, 0.0f);
        else if (PlayerPrefs.GetString("finished") == "LaptopScene")
            Destroy(gameObject, 0.0f);
        else
            Destroy(gameObject, 4.0f);
        
    }
}
