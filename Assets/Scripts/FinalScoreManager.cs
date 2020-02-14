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
        score.text = scorenumber.ToString("0");
        
        
        if (scorenumber > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", scorenumber);
            highscore.text = scorenumber.ToString("0");
        }

        else
            highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();

        
    }


    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()

    {
        Application.Quit();
    }
}
