using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverMenu : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverMenu;

   

   
    void Update()
    {
        if(player == null)
        {
            GameOver();
        }
    }

     void GameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestarGame()
    {
        SceneManager.LoadScene(1);
    }
}
