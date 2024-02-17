using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButt : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("test");
    }
}
