using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.AI;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        UpdateAnimator();
    }


    private void UpdateAnimator()
    {
        Vector3 velocity = _navMeshAgent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;

        GetComponent<Animator>().SetFloat("FowardSpeed", speed);
    }

    public void MoveTo(Vector3 destionation)
    {
        _navMeshAgent.destination = destionation;
    }
}