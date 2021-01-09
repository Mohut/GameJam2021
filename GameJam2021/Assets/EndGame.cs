using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            PlayerPrefs.SetInt("convinced", FindObjectOfType<moveHero>().convinced);
            SceneManager.LoadScene("EndScreen");
        }
    }
}
