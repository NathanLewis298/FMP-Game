using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public MoneyHandler moneyHandler;
   
   
    public float savedCash;
    public float savedTokens;
  
  
   
    void Start()
    {
       
        if(MainMenu.isLoading == true)
        {
            
            savedCash = PlayerPrefs.GetFloat("SavedCash");
            moneyHandler.totalMoney = savedCash;
            
            savedTokens = PlayerPrefs.GetFloat("SavedTokens");
            moneyHandler.totalTokens = savedTokens;
           
     

          

           

          
        }
    }

   
}
