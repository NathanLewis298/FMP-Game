using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveGame : MonoBehaviour
{
    public float saveGameCash;
   
    public GameObject saveButton;
    public MoneyHandler moneyHandler;
   

    public void SaveTheGame()
    {
        
        PlayerPrefs.SetFloat("SavedCash", moneyHandler.totalMoney);
        PlayerPrefs.SetFloat("SavedTokens", moneyHandler.totalTokens);


        PlayerPrefs.Save();
        
    }



}
