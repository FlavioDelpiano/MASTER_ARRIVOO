using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpeed : Bonus
{

    private float normalVelocity, normalMaxVelocity, riderSpeed, riderMaxSpeed;
    public float bonusVelocity = 35;
    public float speedMalusTime = 5;



    // Start is called before the first frame update
    protected override void OnPicked(Collider other)
    {
        base.OnPicked(other);
        ThirdPersonCaracterController other1 = other.GetComponent<ThirdPersonCaracterController>();

        if (!other1) { return; }

        
        normalMaxVelocity = other1.maxSpeed;
        
        other1.maxSpeed = bonusVelocity;
        
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        StartCoroutine(CountdownToBonus(other1));





    }
    // richiamo la coroutine nell'onpicked
    IEnumerator CountdownToBonus(ThirdPersonCaracterController other)
    {




        yield return new WaitForSeconds(5f);




        Debug.Log("fineBonus");
        
        other.maxSpeed = normalMaxVelocity;
        
        Destroy(gameObject);

    }
}
