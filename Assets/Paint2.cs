using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint2 : MonoBehaviour
{
    public static Paint2 instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(transform.gameObject);
        DontDestroyOnLoad(transform.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
