using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusFly : MonoBehaviour
{

    public int impulseforward = 6000 ;

    public int impulseup = 2000;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("bonusfly");
        Rigidbody rb = other.GetComponent<Rigidbody>();
        GameObject characterGameObject = other.gameObject;


        if (characterGameObject.name == "Player")
        {
            rb.AddForce(characterGameObject.transform.forward * impulseforward, ForceMode.Impulse);
            rb.AddForce(characterGameObject.transform.up * impulseup, ForceMode.Impulse);
            FindObjectOfType<AudioManager2>().Play("boost");
        }
        
    }
    
        
       
        
    

}
