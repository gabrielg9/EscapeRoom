using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class machineButton : MonoBehaviour
{
    public bool onTrigger;
    public bool pressed = false;
    public GameObject button;

    [SerializeField] private Vector3 position, returnPosition;
    [SerializeField] private float animationTime;
    private Hashtable iTweenArgs;

    public static machineButton instance = null;

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
        if(onTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                press();
                //unpress();
                pressed = true;
            }
        }
    }

    private void press()
    {
        iTweenArgs["position"] = position;
        iTween.MoveTo(button, iTweenArgs);
        StartCoroutine(Wait());
        
    }
     IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        unpress();
    }

    private void unpress()
    {
        iTweenArgs["position"] = returnPosition;
        iTween.MoveTo(button, iTweenArgs);
    }
}
