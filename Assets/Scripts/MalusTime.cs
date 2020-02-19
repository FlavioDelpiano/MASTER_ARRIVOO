using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalusTime : Bonus
{
    // Start is called before the first frame update
    public float timeMinus = 10;
    protected override void OnPicked(Collider other)
    {
        base.OnPicked(other);
        ThirdPersonCaracterController timer = other.GetComponent<ThirdPersonCaracterController>();

        if (!timer) { return; }

        FindObjectOfType<AudioManager2>().Play("malus");
        timer.TimeRulesMinus(timeMinus);
        Destroy(gameObject);
    }
}
