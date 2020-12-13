using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Level 1

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Lanjut1()
    {
        SceneManager.LoadScene("Level 2");
    }

    #endregion

    #region Level 2

    public void Lanjut2()
    {
        SceneManager.LoadScene("Level 3");
    }

    #endregion

    #region Level 3

    public void Lanjut3()
    {
        SceneManager.LoadScene("MainMenu");
    }

    #endregion

    #region MainMenu
    public void playIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void Quit()
    {
        Application.Quit();
    }
    #endregion

    #region MainMenu
    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }
    #endregion
}
