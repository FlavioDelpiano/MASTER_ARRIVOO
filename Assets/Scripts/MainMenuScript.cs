using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("City");
    }

    public void QuitGame() {
        Debug.Log("Hai quittato");
        Application.Quit();
    }
   
}
