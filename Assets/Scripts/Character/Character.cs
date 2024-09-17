using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Character : MonoBehaviour
{
    public CharacterController CharacterController;
    protected virtual void Awake()
    {
        CharacterController = GetComponent<CharacterController>();
    }
    protected virtual void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("HitEnemy");
            UIBattleInfo.Instance.ShowBattleInfo();
            
        }
    }
}
