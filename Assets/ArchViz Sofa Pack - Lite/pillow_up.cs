using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pillow_up : MonoBehaviour
{
    public bool onTrigger;
    [SerializeField] private Vector3 startPosition, movedPosition;
    [SerializeField] private float animationTime;
    [SerializeField] private Vector3 rotation;
    private Hashtable iTweenArgs;
    private bool moved = false;
    private bool phone = false;

    void Start()
    {
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", movedPosition);
        iTweenArgs.Add("rotation", rotation);
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
        if(moved == false)
        {
            if (onTrigger)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if(phone == false)
                    {
                        iTween.MoveTo(gameObject, iTweenArgs);
                        iTween.RotateTo(gameObject, iTweenArgs);
                        phone = true;
                    }
                    else
                    {
                        Debug.Log("phone");
                        SceneManager.LoadScene("Mobile_phone");
                        
                    }
                    
                }
            }
        }

        
       
      
    }
}
