using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcase : MonoBehaviour
{
    public bool onTrigger;
    public GameObject GameObject;
    public bool outOfTrigger;
    private bool isMoved = false;
    [SerializeField] private Vector3 startPosition, movedPosition, endPosition;
    [SerializeField] private float animationTime;
    [SerializeField] private Vector3 rotation, endRotation;
    private Hashtable iTweenArgs;
    int count = 0;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
        //outOfTrigger = false;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        //outOfTrigger = true;
    }
    void Start()
    {
        onTrigger = false;
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", movedPosition);
        iTweenArgs.Add("rotation", rotation);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
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
                    onTrigger = true;
                                    }
                else
                {
                    iTweenArgs["position"] = movedPosition;
                    iTweenArgs["rotation"] = rotation;
                    Debug.Log("jest");
                    onTrigger = true;
                    outOfTrigger = true;
                }
                isMoved = !isMoved;
                iTween.MoveTo(GameObject, iTweenArgs);
                iTween.RotateTo(GameObject, iTweenArgs);
            }
        }
        /*else
        {
            if (outOfTrigger == true)
            {
                iTweenArgs["position"] = endPosition;
                iTweenArgs["rotation"] = endRotation;
                iTween.MoveTo(GameObject, iTweenArgs);
                iTween.RotateTo(GameObject, iTweenArgs);
                Debug.Log("nie ma");
                outOfTrigger = false;
            }
        }*/

        /*if(entryFirstTime)
        {
            if (outOfTrigger == true)
            {
                iTweenArgs["position"] = endPosition;
                iTweenArgs["rotation"] = endRotation;
                iTween.MoveTo(GameObject, iTweenArgs);
                iTween.RotateTo(GameObject, iTweenArgs);
                
                Debug.Log("przesunieto");
                //outOfTrigger = false;
                //iTweenArgs["position"] = movedPosition;
                //iTweenArgs["rotation"] = rotation;
                isMoved = false;
            }
            
            //isMoved = false;
        }*/
        
    }
}
