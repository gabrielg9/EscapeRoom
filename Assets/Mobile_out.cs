using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mobile_out : MonoBehaviour
{
    public Button button;
    public bool pressButton;
    public GameObject canvas;
    [SerializeField] private Vector3 startPosition, movedPosition;
    [SerializeField] private float animationTime;
    private Hashtable iTweenArgs;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", movedPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("islocal", true);
        pressButton = false;

        PlayerPrefs.SetString("finished", "MobileScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 220, 25), "Naciśnij 'Esc' by wrócić do pokoju");
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("EscapeRoom");
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        iTween.MoveTo(canvas, iTweenArgs);
        pressButton = true;
    }
}
