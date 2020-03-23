using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
    public float totalMoney = 2f;
    public float totalTokens = 0f;
    public Store store;
    public Text tokenAmount;
    // Update is called once per frame
    void Update()
    {
        store.DisplayPrices(gameObject.GetComponent<Text>(), totalMoney);

        tokenAmount.text = totalTokens.ToString();
    
    }
}
