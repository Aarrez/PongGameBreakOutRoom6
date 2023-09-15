using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    public GameObject MenuPanel;

    public void PauseUnPause()
    {
        if (Time.timeScale == 1f)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        MenuPanel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        MenuPanel.SetActive(false);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene((SceneManager.GetActiveScene().name));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
