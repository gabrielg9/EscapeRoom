using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bookcase : MonoBehaviour
{
    public GameObject GameObject;
    public bool onTrigger;
    [SerializeField] private Vector3 startPosition, movedPosition;
    [SerializeField] private float animationTime;
    [SerializeField] private Vector3 rotation;
    private Hashtable iTweenArgs;

    private void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        onTrigger = false;
    }
    void Start()
    {
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
                iTween.MoveTo(GameObject, iTweenArgs);
                iTween.RotateTo(GameObject, iTweenArgs);
            }
        }
    }
}
