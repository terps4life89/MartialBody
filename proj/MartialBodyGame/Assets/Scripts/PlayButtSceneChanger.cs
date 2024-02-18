using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PlayButtSceneChanger : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool buttonPressed = false;
    private float buttonPressTime = 0f;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
        buttonPressTime = Time.time;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;

        // Check if the button was pressed for at least 1 second
        if (Time.time - buttonPressTime >= 1f)
        {
            SceneManager.LoadScene("PreRunMenu"); // Load the specified scene
        }
    }
}
