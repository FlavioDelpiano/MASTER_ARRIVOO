using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Quartiere : MonoBehaviour
    {
        // Start is called before the first frame update
        public BoxCollider[] pedestrians;
        public Percorso1[] AnimationState;
        public Transform player;
        public int distanceToPlay = 300;
        private int var = 0;
        void Awake()
        {
            pedestrians = GetComponentsInChildren<BoxCollider>();
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
            Debug.Log("able");
            foreach (BoxCollider col in pedestrians)
            {
                col.enabled = false;
            }
            foreach (Percorso1 p in AnimationState)
            {
                p.StopAnimation();

            }
        }
        void AbleFunction()
        {
            Debug.Log("disable");
            foreach (BoxCollider col in pedestrians)
            {
                col.enabled = true;
            }
            foreach (Percorso1 p in AnimationState)
            {
                p.PlayAnimation();

            }
        }
    }

