﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SpawnTarget : MonoBehaviour
{
    public Transform[] array = new Transform[5];
    int random;
    public GameObject generate;
    private Transform target;
    public Image img;
    public Text meter;
    public Vector3 offset;
    public float plusScore = 10, totalScore = 0;
    [SerializeField] Text counterScore;
    Vector2 pos;
    // Use this for initialization
    void Start()
    {
        
        Spawner();
        totalScore = 0;
        counterScore.text = totalScore.ToString("0");
    }
    public void Spawner()
    {
        random = Random.Range(0, array.Length);
        GameObject clone = Instantiate(generate, array[random].transform.position, array[random].transform.rotation) as GameObject;
        target = clone.transform;
       
    }

   
    

    void Update()
    {
        
        //if (img == null)
        //    Debug.LogError("null image");

        //if (Camera.main == null)
        //    Debug.LogError("Null camera");

        //if (target == null)
        //    Debug.LogError("TargetNull");

        float minX = img.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;
        float minY = img.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.height - minY;

        pos = Camera.main.WorldToScreenPoint(target.position+ offset);

        if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
        {
            if (pos.x < Screen.width / 2)
            {
                pos.x = maxX;
            }
            else
            {
                pos.x = minX;
            }
        
        }

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        img.transform.position = pos;
        meter.text = ((int)Vector3.Distance(target.position, transform.position)-3).ToString();


    }
    public void ScoreRulesPlus(float plusScore)
    {
        totalScore += plusScore;
        counterScore.text = totalScore.ToString("0");
    }

    public float GetTotalScore()
    {
        return totalScore;
    }
}