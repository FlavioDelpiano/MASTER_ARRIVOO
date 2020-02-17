using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pausedMenuUI;
     
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        if (GameIsPaused)
    //            Resume();
    //        else
    //            Pause();
        
    //    }
    //}

    public void Resume() {

        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Pause()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
