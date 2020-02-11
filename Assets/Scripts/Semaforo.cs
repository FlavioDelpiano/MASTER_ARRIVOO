using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Semaforo : MonoBehaviour
{
    public bool goOn = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RedGreen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        Percorso1 car = other.GetComponent<Percorso1>();

        if (!car) { return; }
        
        if (goOn == false)
            car.TrafficLightRed();
        else
            car.TrafficLightGreen();
    }

    IEnumerator RedGreen()
    {

        while (gameObject.activeSelf)
        {
            yield return new WaitForSeconds(20f);
            goOn = !goOn;
        }

    }
}
