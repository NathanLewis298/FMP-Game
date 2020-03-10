using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
    public float totalMoney = 2f;
    public Store store;

    // Update is called once per frame
    void Update()
    {
        store.DisplayPrices(gameObject.GetComponent<Text>(), totalMoney);
    }
}
