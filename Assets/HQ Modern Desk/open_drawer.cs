using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_drawer : MonoBehaviour
{
    public bool onTrigger;
    
    [SerializeField] private Vector3 openPosition, closedPosition;
    [SerializeField] private float animationTime;
    private Hashtable iTweenArgs;

    public bool isOpen = false;

    private AudioSource audioClip;

    void Start()
    {
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
        audioClip = gameObject.GetComponent<AudioSource>();
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
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (isOpen)
                    iTweenArgs["position"] = closedPosition;
                else
                    iTweenArgs["position"] = openPosition;

                audioClip.Play();

                isOpen = !isOpen;

                iTween.MoveTo(gameObject, iTweenArgs);
            }
        }
    }
}
