using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedoneSegueLepre : MonoBehaviour
{
    public Transform lepre;
    NavMeshAgent agent;
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        
    }
    private void Update()
    {
        agent.SetDestination(lepre.position);
    }
}
