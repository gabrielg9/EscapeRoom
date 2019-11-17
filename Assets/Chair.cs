using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chair : MonoBehaviour
{
    public bool onTrigger;
    [SerializeField] private Vector3 startPosition, movedPosition;
    [SerializeField] private float animationTime;
    [SerializeField] private Vector3 rotation, rotationBack;
    private Hashtable iTweenArgs;

    private int count = 0;

    public GameObject FPSController;

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
        count = 0;
    }

    void Update()
    {
        if(onTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                count++;
                if(count == 1)
                {
                    iTweenArgs["position"] = movedPosition;
                    iTweenArgs["rotation"] = rotation;
                    moveChair();
                }              
                else if(count > 1)
                {
                    FPSController.GetComponent<SavingPosition>().Save();
                    SceneManager.LoadScene("Crossword");
                }
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
