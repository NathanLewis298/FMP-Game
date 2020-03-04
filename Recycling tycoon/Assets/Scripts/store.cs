﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class store : MonoBehaviour
{
    float CurrentBalance;
    float BaseStoreCost;
    float BaseStoreProfit;

    MoneyHandler mh;

    int StoreCount;
    public Text CostText;
    public Text StoreCountText;
    public Text CurrentBalanceText;
    public Text AmountGenText;
    public Slider ProgressSlider;
    public float multiplier = 1.3f;
    public int upgradeCount = 1;
    public float totalValue;
    float StoreTimer = 2f;
    float CurrentTimer = 0;
    bool StartTimer;

    void Start()
    {
        StoreCount = 1;
        CurrentBalance = 2.0f;
        BaseStoreCost = 1.50f;
        BaseStoreProfit = .50f;
        CostText.text = BaseStoreCost.ToString("C2");
        AmountGenText.text = BaseStoreProfit.ToString("C2");
        StartTimer = false;
        totalValue = BaseStoreProfit;
        mh = FindObjectOfType<MoneyHandler>();
    }

   
    void Update()
    {

        if (StartTimer)
        {
            CurrentTimer += Time.deltaTime;
            if (CurrentTimer > StoreTimer)
            {
                Debug.Log("Timer has ended. Reset.");
                StartTimer = false;
                CurrentTimer = 0f;
                mh.totalMoney += totalValue;
                //AmountGenText.text = BaseStoreProfit.ToString("C2");
            }
            
        }

        ProgressSlider.value = CurrentTimer / StoreTimer;

    }

    public void BuyStoreOnClick ()
    {
        if (BaseStoreCost > mh.totalMoney)
            return;
        StoreCount = StoreCount + 1;
        Debug.Log(StoreCount);
        StoreCountText.text = StoreCount.ToString();
        mh.totalMoney -= BaseStoreCost;
        Debug.Log(CurrentBalance);
        BaseStoreCost *= multiplier;

        // BaseStoreProfit *= StoreCount;

        totalValue = BaseStoreProfit * StoreCount;

        CostText.text = BaseStoreCost.ToString("C2");
        AmountGenText.text = totalValue.ToString("C2");
    }

    public void StoreOnClick()
    {
        Debug.Log("Clicked on store");
        if (!StartTimer)
            StartTimer = true;
    }
}
