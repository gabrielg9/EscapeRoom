using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcase : MonoBehaviour
{
    public bool onTrigger;
    public GameObject Book;
    public Canvas textCode;
    private bool isMoved;
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
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
        isMoved = false;
        textCode.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isMoved = false;
                if (isMoved == false)
                {
                    iTweenArgs["position"] = movedPosition;
                    iTweenArgs["rotation"] = rotation;
                    moveAndRotate();
                    textCode.enabled = true;
                }
                isMoved = !isMoved;
            } 
        }
        else
        {
            if(isMoved )
            {
                iTweenArgs["position"] = endPosition;
                iTweenArgs["rotation"] = endRotation;
                moveAndRotate();
                textCode.enabled = false;
            }
        }
    }

    public void moveAndRotate()
    {
        iTween.MoveTo(Book, iTweenArgs);
        iTween.RotateTo(Book, iTweenArgs);
        isMoved = false;
    }
}
