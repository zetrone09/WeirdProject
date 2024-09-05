using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Character : MonoBehaviour
{
    public NavMeshAgent agent;

    protected virtual void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
}
