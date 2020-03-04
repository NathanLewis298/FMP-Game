using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyHandler : MonoBehaviour
{
    public float totalMoney = 2f;

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = totalMoney.ToString("C2");
    }
}
