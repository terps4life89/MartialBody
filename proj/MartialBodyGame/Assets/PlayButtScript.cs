using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public string buttonName = "Play"; // Replace with the name of your button
    public float requiredDuration = 1.0f; // Replace with the desired duration in seconds

    private bool buttonPressed = false;
    private float buttonPressStartTime = 0.0f;

    public void Update()
    {
        if (Input.GetButtonDown(buttonName))
        {
            buttonPressed = true;
            buttonPressStartTime = Time.time;
        }

        if (Input.GetButtonUp(buttonName))
        {
            buttonPressed = false;
        }

        if (buttonPressed && Time.time - buttonPressStartTime >= requiredDuration)
        {
            SceneManager.LoadScene("test");
        }
    }
}
