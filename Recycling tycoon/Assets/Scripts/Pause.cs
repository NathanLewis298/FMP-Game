using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public string mainMenuScene;
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }

        else
        {
            DeactivateMenu();
        }

    }

   public void ActivateMenu()
    {
  
        pauseMenuUI.SetActive(true);
        isPaused = true;
    }

    public void DeactivateMenu()
    {
    
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }

   
    public void Return()
    {
        
        SceneManager.LoadScene(mainMenuScene);
    }

    public void QuitGame()
    {
    

        Debug.Log("Quitted Yourself!!!");
        Application.Quit();
    }
}
