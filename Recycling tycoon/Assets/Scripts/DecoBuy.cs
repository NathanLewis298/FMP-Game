using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoBuy : MonoBehaviour
{
    public int generateTone;
    public AudioSource Building;
    public int decoCost;
    public GameObject[] itemToBuy;
    public int currentDeco = 0;
    public MoneyHandler moneyHandler;
    public bool gameOver = false;
    public void BuyDeco()
    {

        generateTone = UnityEngine.Random.Range(1, 1);

        if (moneyHandler.totalTokens >= decoCost)
        {
            if (currentDeco < itemToBuy.Length)
            {
                itemToBuy[currentDeco].SetActive(true);

                currentDeco++;

                moneyHandler.totalTokens -= decoCost;
                if (generateTone == 1)
                {
                    Building.Play();

                }
            }
        }
       

       if(currentDeco == itemToBuy.Length)
        {
            gameOver = true;
            this.gameObject.SetActive(false);
        }


    }


    public void Start()
    {
        moneyHandler = FindObjectOfType<MoneyHandler>();
    }








}
