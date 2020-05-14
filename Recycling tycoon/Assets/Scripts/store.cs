using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Store : MonoBehaviour
{
    float currentTimer = 0;
    bool startTimer;
    float currentBalance;

    MoneyHandler moneyHandler;

    public float baseStoreProfit;
    public float StoreTimer = 2f;
    public int ownedStores = 0;
    public float baseStoreCost;
    public bool loopAfterpurchase = true;

    public Text texttimer;
    public Text costText;
    public Text StoreCountText;
    public Text CurrentBalanceText;
    public Text amountGenText;
    public Slider ProgressSlider;
    public float multiplier = 1.35f;
    public int upgradeCount = 1;
    public float totalValue;
    public AudioSource cashOne;
    public int generateTone;
    public Button colourGreen;

    void Start()
    {
        costText.text = baseStoreCost.ToString("C2");
        amountGenText.text = baseStoreProfit.ToString("C2");
        startTimer = false;
        totalValue = baseStoreProfit;
        moneyHandler = FindObjectOfType<MoneyHandler>();

        DisplayPrices(costText, baseStoreCost);
        DisplayPrices(amountGenText, baseStoreProfit);
    }

    void Update()
    {
        if (loopAfterpurchase && (!startTimer && ownedStores > 0))
            startTimer = true;

        if (startTimer)
        {
            currentTimer += Time.deltaTime;
            texttimer.text = Math.Round(StoreTimer - currentTimer).ToString();
            if (currentTimer > StoreTimer)
            {
                //Debug.Log("Timer has ended. Reset.");
                startTimer = false;
                currentTimer = 0f;
                moneyHandler.totalMoney += totalValue;
            }

        }

        ProgressSlider.value = currentTimer / StoreTimer;
            
        if (moneyHandler.totalMoney >= baseStoreCost)
        {
            ColorBlock colors = colourGreen.colors;
            colors.normalColor = Color.green;
            colourGreen.colors = colors;
        }
        else
        {
            ColorBlock colors = colourGreen.colors;
            colors.normalColor = Color.red;
            colourGreen.colors = colors;
        }

    }

    public void BuyStoreOnClick()
        
    {
        generateTone = UnityEngine.Random.Range(1,1);
        if (baseStoreCost > moneyHandler.totalMoney)
            return;
        ownedStores = ownedStores + 1;
        if (generateTone == 1)
        {
            cashOne.Play();

        }
        //Debug.Log(ownedStores);
        StoreCountText.text = ownedStores.ToString();
        moneyHandler.totalMoney -= baseStoreCost;
        //Debug.Log(currentBalance);
        baseStoreCost *= multiplier;

        totalValue = baseStoreProfit * ownedStores;

        DisplayPrices(costText, baseStoreCost);
        DisplayPrices(amountGenText, totalValue);
    }

    public void ClickToGenerateMoney()
    {
        //Debug.Log("Clicked on store");
        if (!startTimer)
            startTimer = true;
    }

    public void DisplayPrices(Text text, float money)
    {
        text.text = money.ToString("C2");

        if (money / 1000 >= 1)
        {
            text.text = "£" + Math.Round(money / 1000, 3).ToString() + "K";
        }
        if (money / 1000000 >= 1)
        {
            text.text = "£" + Math.Round(money / 1000000, 3).ToString() + "M";
        }

        if (money / 1000000000 >= 1)
        {
            text.text = "£" + Math.Round(money / 1000000000, 3).ToString() + "B";
        }

    }

}
