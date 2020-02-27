using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Quartiere : MonoBehaviour
    {
        // Start is called before the first frame update
        public BoxCollider[] boxColliders;
        
        public Percorso1[] AnimationState;
        public Bonus[] bonus;
        public NavMeshAgent[] agents;
        public Transform player;
        public CapsuleCollider[] capsuleColliders;
        public int distanceToPlay = 300;
        private int var = 0;
    void Awake()
        {
        
        agents = GetComponentsInChildren<NavMeshAgent>();
            bonus = GetComponentsInChildren<Bonus>();
            boxColliders = GetComponentsInChildren<BoxCollider>();
            capsuleColliders = GetComponentsInChildren<CapsuleCollider>();
            if (((int)Vector3.Distance(player.position, transform.position) - 3) > distanceToPlay)
                var = 0;
            else
                var = 1;
            AnimationState = GetComponentsInChildren<Percorso1>();
        }
    private void Start()
    {
        if (var == 0)
            DisableFunction();
    }


    void Update()
        {
            if (((int)Vector3.Distance(player.position, transform.position) - 3) > distanceToPlay && var == 1)
            {
                var = 0;
                DisableFunction();
            }
            if (((int)Vector3.Distance(player.position, transform.position) - 3) <= distanceToPlay && var == 0)
            {
                var = 1;
                AbleFunction();
            }




        }

        void DisableFunction()
        {
            //Debug.Log("able");
            
        foreach (BoxCollider col in boxColliders)
            {
                col.enabled = false;
            }
            
        foreach (Percorso1 p in AnimationState)
            {
                p.StopAnimation();

            }
            
        foreach (Bonus b in bonus)

                b.varUpDown = false;

            
        foreach (CapsuleCollider c in capsuleColliders)

                c.enabled = false;
            
        foreach (NavMeshAgent n in agents)

                n.Stop();
        


    }
        void AbleFunction()
        {
            //Debug.Log("disable");
            foreach (BoxCollider col in boxColliders)
            {
                col.enabled = true;
            }
            foreach (Percorso1 p in AnimationState)
            {
                p.PlayAnimation();

            }
            
            foreach(Bonus b in bonus)

                b.varUpDown = true;

            foreach (CapsuleCollider c in capsuleColliders)

                c.enabled = true;
        foreach (NavMeshAgent n in agents)

            n.Resume();


    }
}

