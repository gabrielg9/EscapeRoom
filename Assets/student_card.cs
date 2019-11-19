using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class student_card : MonoBehaviour
{
    public GameObject Carpet;
    public GameObject Radio;
    public bool onTrigger;
    [SerializeField] private Vector3 startPosition, movedPosition;
    [SerializeField] private float animationTime;
    private Hashtable iTweenArgs;

    public bool listenedFlag = false;

    private bool movedCarpet = false;
    private bool popup = false;

    public static student_card instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(transform.gameObject);
        DontDestroyOnLoad(transform.gameObject);
    }

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
    }

    // Update is called once per frame
    void Update()
    {
        listenedFlag = Radio.GetComponent<Music>().listened;
        if(onTrigger)
        {
            if(listenedFlag)
            {
                if (movedCarpet)
                {
                    if (Input.GetKeyDown(KeyCode.R))
                    {
                        Camera.main.fieldOfView = 20.0f;
                        popup = false;
                    } 
                }   

                if (Input.GetKeyDown(KeyCode.E))
                {
                    iTweenArgs["position"] = movedPosition;
                    moveCarpet();
                    movedCarpet = true;
                    popup = true;
                }
            }
        }
        else
        {
            Camera.main.fieldOfView = 60.0f;
            popup = false;
        }
    }

    private void OnGUI()
    {
        if (popup)
        {
            GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 15, 400, 30), "By powiększyć legitymację, naciśnij klawisz 'R'");
        }
    }

    private void moveCarpet()
    {
        iTween.MoveTo(Carpet, iTweenArgs);
    }
}
