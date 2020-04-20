using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public static bool isLoading = false;
    public string Tycoon;
    public void NewGame()
    {
        SceneManager.LoadScene(Tycoon);
    }
    public void QuitGame()
    {
        Debug.Log("Quitted Yourself!!!");
        Application.Quit();
    }

    public void LoadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(2);
    }
}

