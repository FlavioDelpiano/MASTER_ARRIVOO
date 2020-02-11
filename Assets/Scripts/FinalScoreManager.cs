using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class FinalScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float scorenumber;
    [SerializeField] Text score;
    [SerializeField] Text highscore;

    public void Start()
    {
        scorenumber = PlayerPrefs.GetFloat("Score", 0);
        score.text = scorenumber.ToString();
        if (scorenumber > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", scorenumber);
            highscore.text = scorenumber.ToString();
        }

        else
            highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Hai quittato");
        Application.Quit();
    }
}
