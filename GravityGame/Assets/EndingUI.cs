using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingUI : MonoBehaviour
{
    //Returns User to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
