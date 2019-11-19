using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPosition : MonoBehaviour
{
    public static int iterator = 0;

    // Start is called before the first frame update
    void Start()
    {
        Load();
        iterator++;
    }
    public void Load()
    {
        if (iterator != 0)
        {
            gameObject.GetComponent<CharacterController>().enabled = false;
            gameObject.transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
            gameObject.transform.rotation = Quaternion.Euler(PlayerPrefs.GetFloat("x_rot"), PlayerPrefs.GetFloat("y_rot"), PlayerPrefs.GetFloat("z_rot"));
            gameObject.GetComponent<CharacterController>().enabled = true;
        }
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("x", transform.position.x);
        PlayerPrefs.SetFloat("y", transform.position.y);
        PlayerPrefs.SetFloat("z", transform.position.z);
        PlayerPrefs.SetFloat("x_rot", transform.rotation.eulerAngles.x);
        PlayerPrefs.SetFloat("y_rot", transform.rotation.eulerAngles.y);
        PlayerPrefs.SetFloat("z_rot", transform.rotation.eulerAngles.z);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
