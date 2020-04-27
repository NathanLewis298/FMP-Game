using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Bonus : MonoBehaviour
{
    public float bonusMoney;
    public float speed;
    public float horizontalSpeed;


    private void Update()
    {
        
        
        transform.position = new Vector2(transform.position.x + Mathf.Sin(Time.time)*horizontalSpeed, transform.position.y - speed * Time.deltaTime);
    
    
    }

    private void Start()
    {
        Destroy(gameObject, 40);
    }


    public void CollectBonus()
    {
        var thehandler = FindObjectOfType<MoneyHandler>();
        thehandler.totalMoney += thehandler.totalMoney / 5;
        Destroy(gameObject);
    }







    }
