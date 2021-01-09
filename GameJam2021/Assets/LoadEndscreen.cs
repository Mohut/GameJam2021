using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LoadEndscreen : MonoBehaviour
{
    [SerializeField] private int keyValue;
    [SerializeField] private GameObject outcomeOne;
    [SerializeField] private GameObject outcomeTwo;
    [SerializeField] private GameObject outcomeThree;
    [SerializeField] private GameObject outcomeFour;
    [SerializeField] private GameObject outcomeFive;
    [SerializeField] private GameObject outcomeSix;

    private void Start()
    {
        keyValue = PlayerPrefs.GetInt("convinced");
        if (keyValue == 0)
        {
            outcomeOne.SetActive(true);
        }

        if (keyValue == 1)
        {
            outcomeTwo.SetActive(true);
        }

        if (keyValue == 2)
        {
            outcomeThree.SetActive(true);
        }

        if (keyValue == 3)
        {
            outcomeFour.SetActive(true);
        }

        if (keyValue == 4)
        {
            outcomeFive.SetActive(true);
        }

        if (keyValue == 5)
        {
            outcomeSix.SetActive(true);
        }
    }
    
}
