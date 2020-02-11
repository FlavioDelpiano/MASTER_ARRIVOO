using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    public float RotationSpeed = 3;
    public Transform Target,Player;
    public float dstFromTarget = 0.5f;
    float mouseX,mouseY ;
    public float rotationSmoothTime = .12f;
    Vector3 rotationSmoothVelocity, currentRotation;

    
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void LateUpdate() {
        CamControl();
        
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime ;
        mouseY += Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime ;
        mouseY = Mathf.Clamp(mouseY, -30 , 10);

        //transform.LookAt(Target);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(-mouseY, mouseX), ref rotationSmoothVelocity , rotationSmoothTime);
        transform.eulerAngles = currentRotation;

        transform.position = Target.position - transform.forward * dstFromTarget;

        //Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
        
               
    }




    
}
