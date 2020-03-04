using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wind : MonoBehaviour
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
    public float multiplier = 1.15f;
    public int upgradeCount = 0;
    public float totalValue;
    float StoreTimer = 45f;
    float CurrentTimer = 0;
    bool StartTimer;

    void Start()
    {
        StoreCount = 0;
        CurrentBalance = 2.0f;
        BaseStoreCost = 1000.00f;
        BaseStoreProfit = 30.25f;
        CostText.text = BaseStoreCost.ToString("C2");
        AmountGenText.text = BaseStoreProfit.ToString("C2");
        StartTimer = false;
        totalValue = BaseStoreProfit;
        mh = FindObjectOfType<MoneyHandler>();
    }


    void Update()
    {
        if (!StartTimer && StoreCount > 0)
            StartTimer = true;

        if (StartTimer)
        {
            CurrentTimer += Time.deltaTime;
            if (CurrentTimer > StoreTimer)
            {
                Debug.Log("Timer has ended. Reset.");
                StartTimer = false;
                CurrentTimer = 0f;
                mh.totalMoney += totalValue;
            }

        }

        ProgressSlider.value = CurrentTimer / StoreTimer;

    }

    public void BuyStoreOnClick()
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
