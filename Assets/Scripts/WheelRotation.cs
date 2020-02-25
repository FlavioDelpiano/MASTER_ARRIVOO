using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public int rotationSpeed = 30;
    private void Update()
    {
        transform.Rotate(Vector3.left, rotationSpeed * Time.deltaTime, Space.Self);
    }
    
}
