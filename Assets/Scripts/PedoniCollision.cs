using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedoniCollision : MonoBehaviour
{
    public float multaPedone = 5 ;
    public AudioManager2 aud;


    
    void OnCollisionEnter(Collision collision) 
    {
         
        //Debug.Log(collision.gameObject.name);
        ThirdPersonCaracterController character = collision.collider.GetComponent<ThirdPersonCaracterController>();

       //if (!character) { Debug.Log("errore"); } //--> RICORDARSI DI CHIEDERE PERCHè CHARACTER NON VIENE RIEMPITO MA LE MULTE LE AGGIUNGE LO STESSO
        
       
       if (character != null )        
            {
                
                Debug.Log("hai investito " + gameObject.name);
                character.MultaPlus(multaPedone);
                aud.Play("urloPedone");
        }
      

    }

  

}
