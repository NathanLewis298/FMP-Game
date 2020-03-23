using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exchange : MonoBehaviour
{
    public MoneyHandler moneyHandler;
    public int generateTone;
    public AudioSource tokens;
    private void Start()
    {
        moneyHandler = FindObjectOfType<MoneyHandler>();
    }
    public void ExchangeCurrency()
    {
        generateTone = UnityEngine.Random.Range(1, 1);
        
        if (moneyHandler.totalMoney >= 1000000)
        {
            moneyHandler.totalMoney -= 1000000;
            
            if (generateTone == 1)
            {
                tokens.Play();

            }
            
            moneyHandler.totalTokens += 1;
        
        
        }
      
    }
}
