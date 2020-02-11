using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
     public bool goUp;
    public float speed = 0.25f;
    public float rotationSpeed = 5f;

    private void Start() {
        StartCoroutine(SwitchDirection());
    }
    void Update()
    {
        if(goUp)
        {
            transform.position= transform.position + new Vector3(0,1*speed*Time.deltaTime,0);
        }
        else
        {
            transform.position= transform.position - new Vector3(0,1*speed*Time.deltaTime,0);
        }

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
    }

    IEnumerator SwitchDirection()
    {
        while(gameObject.activeSelf)
        {
            yield return new WaitForSeconds(0.5f);
            goUp = !goUp;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
            {
                OnPicked(other);
            }

    }

    protected virtual void OnPicked(Collider other)
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<Renderer>().enabled = false;
        Debug.Log("Hai preso : " + gameObject.name);
    }
}
