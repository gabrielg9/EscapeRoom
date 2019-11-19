using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
    public string password = "1919";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
    public Transform door;
    public Transform particles_position;
    public GameObject particles;
    private bool particle = false;

    private AudioSource audioSource;

    public AudioSource openingDoor;
    private int count;

    public GameObject fpsCamera;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
    }

    void Update()
    {
        if(input==password)
        {
            doorOpen = true;
        }
        if(doorOpen)
        {
            if(!particle)
            {
                Instantiate(particles, particles_position.position, Quaternion.identity);
                particle = true;
            }
            if(count == 0)
            {
                openingDoor.Play();
                count++;
            }
            door.rotation = Quaternion.RotateTowards(door.rotation, Quaternion.Euler(-90.0f, -90.0f, 0.0f), Time.deltaTime * 100);
        }
    }

    void OnGUI()
    {
        if (!doorOpen)
        {
            if(onTrigger)
            {
                GUI.Box(new Rect(0, 0, 220, 25), "Naciśnij 'E' by otworzyć szyfrator");
                if(Input.GetKeyDown(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                }
            }

            if(keypadScreen)
            {
                GUI.Box(new Rect(0, 0, 320, 455), "");
                GUI.Box(new Rect(5, 5, 310, 25), input);

                if(GUI.Button(new Rect(5, 35, 100, 100), "1"))
                {
                    audioSource.Play();
                    input = input + "1";
                }
                if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
                {
                    audioSource.Play();
                    input = input + "2";
                }
                if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
                {
                    audioSource.Play();
                    input = input + "3";
                }
                if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
                {
                    audioSource.Play();
                    input = input + "4";
                }
                if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
                {
                    audioSource.Play();
                    input = input + "5";
                }
                if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
                {
                    audioSource.Play();
                    input = input + "6";
                }
                if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
                {
                    audioSource.Play();
                    input = input + "7";
                }
                if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
                {
                    audioSource.Play();
                    input = input + "8";
                }
                if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
                {
                    audioSource.Play();
                    input = input + "9";
                }
                if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
                {
                    audioSource.Play();
                    input = input + "0";
                }
                if (GUI.Button(new Rect(215, 350, 100, 100), "←"))
                {
                    if(input.Length != 0)
                    {
                        audioSource.Play();
                        input = input.Remove(input.Length - 1);
                    }
                }
            }
        }
    }
    
}
