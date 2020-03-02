using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class store : MonoBehaviour
{
    float CurrentBalance;
    float BaseStoreCost;
    int StoreCount;
    public Text StoreCountText;
    public Text CurrentBalanceText;

    void Start()
    {
        StoreCount = 1;
        CurrentBalance = 2.0f;
        BaseStoreCost = 1.50f;
        CurrentBalanceText.text = CurrentBalance.ToString("C2");
    }

   
    void Update()
    {
        
    }

    public void BuyStoreOnClick ()
    {
        if (BaseStoreCost > CurrentBalance)
            return;
        StoreCount = StoreCount + 1;
        Debug.Log(StoreCount);
        StoreCountText.text = StoreCount.ToString();
        CurrentBalance = CurrentBalance - BaseStoreCost;
        Debug.Log(CurrentBalance);
        CurrentBalanceText.text = CurrentBalance.ToString("C2");
    }


}
