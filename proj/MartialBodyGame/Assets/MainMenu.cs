using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    private bool buttonPressed = false;
    private float buttonPressTime = 0f;

    public void OnPointerDown()
    {
        buttonPressed = true;
        buttonPressTime = Time.time;
    }

    public void OnPointerUp()
    {
        buttonPressed = false;

        // Check if the button was pressed for at least 1 second
        if (Time.time - buttonPressTime >= 1f)
        {
            SceneManager.LoadScene("test"); // Load the specified scene
        }
    }

}
