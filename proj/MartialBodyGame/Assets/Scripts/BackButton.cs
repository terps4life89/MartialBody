using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackButton : MonoBehaviour
{
    
    public void PreviousScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
