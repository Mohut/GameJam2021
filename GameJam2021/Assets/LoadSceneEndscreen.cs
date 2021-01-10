using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneEndscreen : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private string key = "convinced";
    public void Restart()
    {
        SceneManager.LoadScene("EnemyScene");
        PlayerPrefs.SetInt(key, score);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        PlayerPrefs.SetInt(key, score);
    }
}
