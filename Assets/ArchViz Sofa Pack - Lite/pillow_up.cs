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
    public bool phone = false;
    private int counter = 0;
    public static pillow_up instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(transform.gameObject);
        DontDestroyOnLoad(transform.gameObject);
    }

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
                    if (phone == false)
                    {
                        iTween.MoveTo(gameObject, iTweenArgs);
                        iTween.RotateTo(gameObject, iTweenArgs);
                        phone = true;
                    }
                    else
                    {
                        counter++;
                        Debug.Log("phone");
                        if(counter == 2)
                            SceneManager.LoadScene("Mobile_phone");
                    }
                }
                if (Input.GetKeyDown(KeyCode.Escape))
                    counter = 1;
            }
            else
                counter = 1;
        }
    }
}
