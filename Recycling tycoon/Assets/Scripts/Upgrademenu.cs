using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrademenu : MonoBehaviour
{
    [SerializeField] private GameObject upgradeMenuUI;




    public void ActivateMenu()
    {
        upgradeMenuUI.SetActive(true);
    }


    public void DeactivateMenu()
    {
        upgradeMenuUI.SetActive(false);
        
    }
}
