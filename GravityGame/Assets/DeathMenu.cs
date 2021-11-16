using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public static bool GameOver = false;
    public GameObject GameOverUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Lost();
        }
        //else
        //{
        //    Winning();
       // }
    }

    public void Lost()
    {
        GameOver = true;
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    void Winning()
    {
        GameOver = false;
        GameOverUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Back()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
