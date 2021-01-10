using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneEndscreen : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("EnemyScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
