using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    private string key = "convinced";
    
    [SerializeField] private int score;
    
    private void Update()
    {
        PlayerPrefs.SetInt(key, score);

        Debug.Log(PlayerPrefs.GetInt(key).ToString());
    }
}
