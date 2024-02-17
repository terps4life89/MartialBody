using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class testScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
            SceneManager.LoadScene("test"); // Load the specified scene
        }
    }
}