using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public bool onTrigger;
    [SerializeField] private Vector3 startPosition, movedPosition;
    [SerializeField] private float animationTime;
    [SerializeField] private Vector3 rotation, rotationBack;
    private Hashtable iTweenArgs;

    void Start()
    {
        iTweenArgs = iTween.Hash();
        //iTweenArgs.Add("position", movedPosition);
        //iTweenArgs.Add("rotation", rotation);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
    }

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }

    void Update()
    {
        if(onTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                iTweenArgs["position"] = movedPosition;
                iTweenArgs["rotation"] = rotation;
                moveChair();
            }
        }
        else
        {
            iTweenArgs["position"] = startPosition;
            iTweenArgs["rotation"] = rotationBack;
            moveChair();
        }
        
    }

    private void moveChair()
    {
        iTween.MoveTo(gameObject, iTweenArgs);
        iTween.RotateTo(gameObject, iTweenArgs);
    }
}
