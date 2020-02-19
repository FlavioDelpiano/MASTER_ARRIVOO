using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalusSpeed : Bonus
{
    private float normalVelocity,normalMaxVelocity,riderSpeed,riderMaxSpeed;
    public float malusVelocity = 5;
    public float speedMalusTime = 5;

    

    // Start is called before the first frame update
    protected override void OnPicked(Collider other)
    {
        base.OnPicked(other);
       ThirdPersonCaracterController other1 = other.GetComponent<ThirdPersonCaracterController>();
        
        if (!other1) { return; }

        
        normalMaxVelocity = other1.maxSpeed;
        
        other1.maxSpeed = malusVelocity;
        
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;
        StartCoroutine(CountdownToBonus(other1));
        FindObjectOfType<AudioManager2>().Play("malus");
        

        


    }
    // richiamo la coroutine nell'onpicked
    IEnumerator CountdownToBonus(ThirdPersonCaracterController other)
    {
        
       
       
     
        yield return new WaitForSeconds(5f);

            

        
        Debug.Log("fineMalus");
        
        other.maxSpeed = normalMaxVelocity;
        
        Destroy(gameObject);

    }
}
    
