using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTime : Bonus
{
    public float timePlus = 10;
    protected override void OnPicked(Collider other)
    {
        base.OnPicked( other);
        ThirdPersonCaracterController timer = other.GetComponent<ThirdPersonCaracterController>();
        
        if (!timer) { return; }

        FindObjectOfType<AudioManager2>().Play("bonus");
        timer.TimeRulesPlus(timePlus);
        Destroy(gameObject);
    }
    
      
   
}
