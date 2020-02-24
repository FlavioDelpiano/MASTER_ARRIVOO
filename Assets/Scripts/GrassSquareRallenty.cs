using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSquareRallenty : MonoBehaviour
{
    public float rallentySpeed = 10;
    private float normalSpeed;
    private void OnCollisionEnter(Collision collision)
    {
        
        ThirdPersonCaracterController other1 = collision.collider.GetComponent<ThirdPersonCaracterController>();

        normalSpeed = other1.maxSpeed;
        other1.maxSpeed = rallentySpeed;

    }

    private void OnCollisionExit(Collision collision)
    {
        ThirdPersonCaracterController other = collision.collider.GetComponent<ThirdPersonCaracterController>();
        other.maxSpeed = normalSpeed;
    
    }

}
