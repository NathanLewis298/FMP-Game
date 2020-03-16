using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeShop : MonoBehaviour
{
    public Store storeToUpgrade;
    public MoneyHandler moneyHandler;
    public int[] numberOfUpgrades = { 2, 3, 4, 5 };
    public float[] upgradeCost = new float[4];

    public float startCost = 500f;
    public float costMultiplier = 3f;

    int curentUpgrade = 0;

    private void Start()
    {
        for (int i = 0; i < upgradeCost.Length; i++)
        {
            if (i == 0)
            {
                upgradeCost[i] = startCost;
            }
            else
            {
                upgradeCost[i] = costMultiplier * upgradeCost[i - 1];
            }

        }
    }

    public void Upgrade()
    {
        if (moneyHandler.totalMoney >= upgradeCost[curentUpgrade])
        {
            storeToUpgrade.totalValue *= numberOfUpgrades[curentUpgrade];
            storeToUpgrade.baseStoreProfit *= numberOfUpgrades[curentUpgrade];
            moneyHandler.totalMoney -= upgradeCost[curentUpgrade];
            storeToUpgrade.DisplayPrices(storeToUpgrade.amountGenText, storeToUpgrade.totalValue);
            curentUpgrade++;
        }
    }
}
