using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSquareRallenty : MonoBehaviour
{
    public float rallentySpeed = 10;
    private float normalSpeed;
    ThirdPersonCaracterController other1;
    private void OnCollisionEnter(Collision collision)
    {
        
        other1 = collision.collider.GetComponent<ThirdPersonCaracterController>();

        

    }

    private void OnCollisionExit(Collision collision)
    {
        ThirdPersonCaracterController other = collision.collider.GetComponent<ThirdPersonCaracterController>();
        other.maxSpeed = normalSpeed;
    
    }

    private void OnCollisionStay(Collision collision)
    {
        normalSpeed = other1.maxSpeed;
        other1.maxSpeed = rallentySpeed;
    }
}
