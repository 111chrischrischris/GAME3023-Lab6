using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        EditorSceneManager.LoadScene("Town", UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

    public void LoadGame()
    {
        SaveSystem.SaveStart = true;
        EditorSceneManager.LoadScene("Town", UnityEngine.SceneManagement.LoadSceneMode.Single);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
