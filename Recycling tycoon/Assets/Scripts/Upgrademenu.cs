using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrademenu : MonoBehaviour
{
    [SerializeField] private GameObject upgradeMenuUI;


    public int generateTone;
    public AudioSource pop;
    public void ActivateMenu()
    {
        generateTone = UnityEngine.Random.Range(1, 1);

        if (generateTone == 1)
        {
            pop.Play();

        }
        upgradeMenuUI.SetActive(true);
    }


    public void DeactivateMenu()
    {
        generateTone = UnityEngine.Random.Range(1, 1);

        if (generateTone == 1)
        {
            pop.Play();

        }
        upgradeMenuUI.SetActive(false);
        
    }
}
