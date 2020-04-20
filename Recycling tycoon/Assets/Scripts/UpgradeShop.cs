using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeShop : MonoBehaviour
{
    public Store storeToUpgrade;
    public MoneyHandler moneyHandler;
    public int[] numberOfUpgrades = { 2, 3, 4, 5 };
    public float[] upgradeCost = new float[4];
    public int generateTone;
    public AudioSource upgradeSound;
    public Text upgradeCostText;
    public Text multiplierText;
    public float startCost = 500f;
    public float costMultiplier = 3f;

    public int curentUpgrade = 0;

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
        multiplierText.text = "X" + numberOfUpgrades[curentUpgrade].ToString();

        storeToUpgrade.DisplayPrices(upgradeCostText, upgradeCost[curentUpgrade]);
    }

    public void Upgrade()
    {
        generateTone = UnityEngine.Random.Range(1, 1);

        if (moneyHandler.totalMoney >= upgradeCost[curentUpgrade])
        {
            storeToUpgrade.totalValue *= numberOfUpgrades[curentUpgrade];
            storeToUpgrade.baseStoreProfit *= numberOfUpgrades[curentUpgrade];
            moneyHandler.totalMoney -= upgradeCost[curentUpgrade];
            storeToUpgrade.DisplayPrices(storeToUpgrade.amountGenText, storeToUpgrade.totalValue);
            curentUpgrade++;

            if (generateTone == 1)
            {
                upgradeSound.Play();

            }



            if (curentUpgrade < numberOfUpgrades.Length)
            {
                multiplierText.text = "X" + numberOfUpgrades[curentUpgrade].ToString();
                storeToUpgrade.DisplayPrices(upgradeCostText, upgradeCost[curentUpgrade]);
            }
            else
                multiplierText.text = "MAXED";
        }
    }
}
