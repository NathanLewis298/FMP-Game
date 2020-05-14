using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoChecker : MonoBehaviour
{
    public DecoBuy[] Script;
    public GameObject gameOverScreen;
    void Start()
    {
        Script = FindObjectsOfType<DecoBuy>();

        InvokeRepeating("checkscripts", 0.5f, 0.5f);
    }


    private void checkscripts()
    {
        bool gameover = true;
        foreach(DecoBuy s in Script)
        {
            if (!s.gameOver)
            {
                gameover = false;
            }
        }
    
        if (gameover)
        {
            gameOverScreen.SetActive(true);
            enabled = false;
        }
        
    }



}
