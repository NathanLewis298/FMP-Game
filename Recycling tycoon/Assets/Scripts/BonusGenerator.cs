using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BonusGenerator : MonoBehaviour
{
    public GameObject bonusSpawn;
    public float bonusSpawnTime;
    private float screenHeight;
    private float screenWidth;
    public Canvas canvas;

    private void Start()
    {
        screenHeight = Screen.height;

        screenWidth = Screen.width;

        InvokeRepeating("spawnBonus", bonusSpawnTime * 60, bonusSpawnTime * 60);
    }


    void spawnBonus()
    {
        Vector2 spawnPoint;
        spawnPoint.y = screenHeight ;
        Debug.Log("working");
        spawnPoint.x = Random.Range(0 , screenWidth );



        var obj=Instantiate(bonusSpawn, canvas.transform);
        obj.GetComponent<RectTransform>().position = spawnPoint;
        obj = null;
    }






}
