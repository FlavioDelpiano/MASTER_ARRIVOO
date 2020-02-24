using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusFly : MonoBehaviour
{

    public int impulseforward = 4000 ;

    public int impulseup = 1000;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        GameObject characterGameObject = collision.collider.gameObject;

        if (characterGameObject.tag == "Player")
        {
            Debug.Log("fly");
            rb.AddForce(characterGameObject.transform.forward * impulseforward, ForceMode.Impulse);
            rb.AddForce(characterGameObject.transform.up * impulseup, ForceMode.Impulse);
        }
    }

}
