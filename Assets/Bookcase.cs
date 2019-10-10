using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcase : MonoBehaviour
{
    public bool onTrigger;
    public GameObject GameObject;
    private bool isMoved = false;
    [SerializeField] private Vector3 startPosition, movedPosition, endPosition;
    [SerializeField] private float animationTime;
    [SerializeField] private Vector3 rotation, endRotation;
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
        //iTweenArgs.Add("position", movedPosition);
        //iTweenArgs.Add("rotation", rotation);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
        onTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isMoved)
                {
                    iTweenArgs["position"] = endPosition;
                    iTweenArgs["rotation"] = endRotation;
                    Debug.Log("nie ma");
                }
                else
                {
                    iTweenArgs["position"] = movedPosition;
                    iTweenArgs["rotation"] = rotation;
                    Debug.Log("jest");
                                        
                }
                
            }
            isMoved = !isMoved;
            iTween.MoveTo(GameObject, iTweenArgs);
            iTween.RotateTo(GameObject, iTweenArgs);
        }
        

        
        
    }
}
