using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedoniCollision : MonoBehaviour
{
    public float multaPedone = 5 ;
    public int impulseforward = 700;
    public int impulseup = 400;



    void OnCollisionEnter(Collision collision) 
    {
         
        //Debug.Log(collision.gameObject.name);
        ThirdPersonCaracterController character = collision.collider.GetComponent<ThirdPersonCaracterController>();
        GameObject characterGameObject = collision.collider.gameObject;
        //if (!character) { Debug.Log("errore"); } //--> RICORDARSI DI CHIEDERE PERCHè CHARACTER NON VIENE RIEMPITO MA LE MULTE LE AGGIUNGE LO STESSO

        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (character != null )        
            {
                
                Debug.Log("hai investito " + gameObject.name);
                character.MultaPlus(multaPedone);
            character.forwardVelocity = 0f;
            rb.AddForce(-characterGameObject.transform.forward * impulseforward, ForceMode.Impulse);
            rb.AddForce(characterGameObject.transform.up * impulseup, ForceMode.Impulse);
            FindObjectOfType<AudioManager2>().Play("malus");
        }
      

    }

  

}
