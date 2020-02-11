using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCar : MonoBehaviour
{
    
    public int multaCar = 7;
    public float stop = 1;
    public float impulseforward = 4000;
    public float impulseup = 4000;
    public AudioManager2 aud;


    

    void OnCollisionEnter(Collision collision)
    {

        ThirdPersonCaracterController character = collision.collider.GetComponent<ThirdPersonCaracterController>();
        GameObject characterGameObject = collision.collider.gameObject;
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();

        if (character != null)
        {
            Debug.Log("hai investito " + gameObject.name);
            character.MultaPlus(multaCar);
        }

        if (characterGameObject.name == "Player")
        {
            Debug.Log("impulso");

            character.forwardVelocity = 0f;
            rb.AddForce(-characterGameObject.transform.forward * impulseforward, ForceMode.Impulse);
            rb.AddForce(characterGameObject.transform.up * impulseup, ForceMode.Impulse);
            aud.Play("clacson");
            
        }
    }

    

}

