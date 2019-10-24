using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureFrame : MonoBehaviour
{
    public GameObject machine;
    public Image Image1;
    public Image Image2;
    private bool metalStretched = false;

    void Start()
    {
        Image1.enabled = false;
        Image2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //metalStretched = machine.GetComponent<Stretch>().streched;
        if(metalStretched)
        {
            Image1.enabled = true;
            Image2.enabled = true;
        }
    }
}
