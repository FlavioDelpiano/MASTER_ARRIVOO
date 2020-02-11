using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargDestroy : MonoBehaviour
{
    public float plusScore = 10;

    

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("TargDestroy on trigger enetr " + collider.gameObject.name);
        ThirdPersonCameraController cr = collider.gameObject.GetComponent<ThirdPersonCameraController>();

        if (collider.gameObject.name == "Player") 
        {
            Debug.Log("TDestroying " + this);
            gameObject.SetActive(false);
            Camera.main.GetComponent<SpawnTarget>().Spawner();
            Destroy(this.gameObject);
            Camera.main.GetComponent<SpawnTarget>().ScoreRulesPlus(plusScore);
           
           

        }
    }

    


}
