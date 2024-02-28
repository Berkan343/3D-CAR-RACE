using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class arabaAI : MonoBehaviour
{
    public Transform[] noktalar;
    public int noktaSayi;
    public NavMeshAgent nav;
    public float normalhiz, mesafe;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();   
    }

    
    void Update()
    {
        nav.SetDestination(noktalar[noktaSayi].position);

        mesafe = Vector3.Distance(transform.position, noktalar[noktaSayi].position);

        if (mesafe < 1)
        {

            noktaSayi++;
        }if(Physics.Raycast(transform.position,transform.forward,5))
        {

            nav.speed = 0;
        }
        else
        {
            nav.speed = normalhiz;
        }if(noktaSayi == noktalar.Length - 1)
        {
            noktaSayi = 0;

        }





    }
}
