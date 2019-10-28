using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public bool streched = false;
    private bool pressed = false;
    public GameObject Button;
    public Canvas canvas;

    [SerializeField] private Vector3 position1, position2, position3, position4, position5, scale, position6;
    [SerializeField] private float animationTime;
    private Hashtable iTweenArgs1;
    private Hashtable iTweenArgs2;
    private Hashtable iTweenArgs3;
    private Hashtable iTweenArgs4;
    private Hashtable iTweenArgs5;
    private Hashtable iTweenArgs6;

    public GameObject cube1;
    public GameObject cylinder1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject metal;

    void Start()
    {
        //canvas.enabled = false; 
        iTweenArgs1 = iTween.Hash();
        iTweenArgs1.Add("time", animationTime);
        iTweenArgs1.Add("islocal", true);

        iTweenArgs2 = iTween.Hash();
        iTweenArgs2.Add("time", animationTime);
        iTweenArgs2.Add("islocal", true);

        iTweenArgs3 = iTween.Hash();
        iTweenArgs3.Add("time", animationTime);
        iTweenArgs3.Add("islocal", true);

        iTweenArgs4 = iTween.Hash();
        iTweenArgs4.Add("time", animationTime);
        iTweenArgs4.Add("islocal", true);

        iTweenArgs5 = iTween.Hash();
        iTweenArgs5.Add("time", animationTime);
        iTweenArgs5.Add("islocal", true);

        iTweenArgs6 = iTween.Hash();
        iTweenArgs6.Add("time", animationTime);
        iTweenArgs6.Add("islocal", true);
    }

    // Update is called once per frame
    void Update()
    {
        pressed = Button.GetComponent<machineButton>().pressed;
        if(pressed)
        {
            moveElements();
            streched = true;
            if (streched)
            {
                canvas.enabled = true;
            }
        }
       
    }

    private void moveElements()
    {
        iTweenArgs1["position"] = position1;
        iTween.MoveTo(cube1, iTweenArgs1);

        iTweenArgs2["position"] = position2;
        iTween.MoveTo(cylinder1, iTweenArgs2);

        iTweenArgs3["position"] = position3;
        iTween.MoveTo(cube2, iTweenArgs3);

        iTweenArgs4["position"] = position4;
        iTween.MoveTo(cube3, iTweenArgs4);

        iTweenArgs5["position"] = position5;
        iTween.MoveTo(cube4, iTweenArgs5);

        iTweenArgs6["scale"] = scale;
        iTweenArgs6["position"] = position6;
        iTween.ScaleTo(metal, iTweenArgs6);
        iTween.MoveTo(metal, iTweenArgs6);
    }
}
