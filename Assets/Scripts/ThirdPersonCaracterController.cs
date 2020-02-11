using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdPersonCaracterController : MonoBehaviour
{

    public float forwardVelocity;
    public float maxSpeed = 20f;
    public float minSpeed = 0f;
    public float timeZerotoMax = 2.5f;
    public float acceleratePerSec;
    public float boost = 2f;


    
    
    
    public float currentTime = 30;
    public float maxTime = 30;
    public float multaTotale = 0;
    [SerializeField] Text countdownText;
    [SerializeField] Text counterMultaTotale;
    public int multaMassima = 40;
    
    

    private void Start() 
    {
        
        StartCoroutine(CountdownToStart());
        
    }

    private void Awake()
    {

        
        acceleratePerSec = maxSpeed / timeZerotoMax;
        forwardVelocity = 0;
    }
    
    void Update()
    {

        PlayerMovement();
     
        counterMultaTotale.text = multaTotale.ToString("0");
        countdownText.text = currentTime.ToString("0.0");

        if (currentTime == 0)
        {
            SceneManager.LoadScene("Final");
            PlayerPrefs.SetFloat("Score", Camera.main.GetComponent<SpawnTarget>().totalScore);
        }
        if (multaTotale >= multaMassima)
        {
            SceneManager.LoadScene("Final");
            PlayerPrefs.SetFloat("Score", Camera.main.GetComponent<SpawnTarget>().totalScore);
        }

    }

    void PlayerMovement()
    {

        float ver = Input.GetAxis("Vertical");

        if (ver > 0 && Input.GetKeyDown(KeyCode.Z) == false)
        {




            forwardVelocity += acceleratePerSec * Time.deltaTime;
            forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {

                maxSpeed = 30f;

            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                maxSpeed = 20f;
            }



            transform.Translate(0, 0, ver * forwardVelocity * Time.deltaTime);
        }

        if (ver == 0 && Input.GetKeyDown(KeyCode.Z)== false)
        {
            forwardVelocity -= acceleratePerSec * Time.deltaTime;
            forwardVelocity = Mathf.Max(forwardVelocity, 0);

            transform.Translate(0, 0, 0.5f * forwardVelocity * Time.deltaTime);
        }

       
    }
    public void MultaPlus(float multaSingola)
    {
        multaTotale += multaSingola;
    }


    public void TimeRulesPlus(float plusTime)
    {
        TimeRulesMinus(-plusTime);
    }

    public void TimeRulesMinus(float minusTime)
    {
        currentTime -= minusTime;


    }

   
    
    IEnumerator CountdownToStart()
    {
        while (currentTime > 0)
        {
           

            yield return new WaitForSeconds(0.1f);

            currentTime = currentTime - 0.1f; 

        }

        currentTime = 0;
        

    }


   
   
    
}
