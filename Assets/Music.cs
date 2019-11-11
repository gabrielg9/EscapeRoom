using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public bool onTrigger;
    public bool listened = false;
    private AudioSource music;
    private AudioSource musicMessageCarpet;
    private bool popup = false;
    public GameObject musicCarpet;
    private int count;
    
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
        musicMessageCarpet = musicCarpet.GetComponent<AudioSource>();
        music = gameObject.GetComponent<AudioSource>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (onTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                musicMessageCarpet.Stop();
                music.Stop();
                popup = true;
                music.Play();
                music.volume = 1.0f;
                listened = true;
                count++;
                StartCoroutine(Wait());
            }
        }
        else
        {
            popup = false;
            //musicMessageCarpet.Stop();
            //music.Stop();
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(10f);
        music.Pause();
        musicMessageCarpet.Play();
        yield return new WaitForSeconds(28f);
        count--;
        if(count == 0)
            music.UnPause();
        music.volume = 0.03f;
    }

    private void OnGUI()
    {
        if (popup)
        {
            GUI.Box(new Rect(Screen.width / 2 - 200, Screen.height / 2 - 15, 400, 30), "Upewnij się, że masz włączone głośniki lub podpięte słuchawki");
        }
    }
}
