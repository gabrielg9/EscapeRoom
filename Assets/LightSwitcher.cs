using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitcher : MonoBehaviour
{
    public GameObject Switcher;
    public GameObject Light;
    public GameObject Wall;
    private Light light;
    public bool onTrigger;
    private bool switched = false;
    [SerializeField] private Vector3 rotation, returnRotation;
    [SerializeField] private float animationTime;
    private Hashtable iTweenArgs;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }
    void Start()
    {
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
        light = Light.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(onTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                switched = !switched;
                if (switched)
                {
                    iTweenArgs["rotation"] = rotation;
                    light.enabled = true;
                    Wall.SetActive(false);
                }
                else
                {
                    iTweenArgs["rotation"] = returnRotation;
                    light.enabled = false;
                    Wall.SetActive(true);
                }
                    
                switchLight();
            }
        }
    }

    private void switchLight()
    {
        iTween.RotateTo(Switcher, iTweenArgs);
    }
}
