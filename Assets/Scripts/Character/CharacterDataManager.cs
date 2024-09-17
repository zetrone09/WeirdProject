using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterDataManager : MonoBehaviour
{
    [Header("Character Info")]
    public CharacterData characterData;
    [SerializeField] private CharacterClassData ClassName;
    [SerializeField] private CharacterTraitData TraitName;
    CharacterMotionManager characterMotionManager;
    private void Awake()
    {
        characterMotionManager = GetComponent<CharacterMotionManager>();
    }
    private void Start()
    {          
        InitializeCharacterData(characterData);
    }
    private void Update()
    {
        if (GameManager.Instance.turnManager.currentTurnState == TurnState.PlayerTurn)
        {
            characterMotionManager.HandleAllMovement();
        }              
    }
    private void InitializeCharacterData(CharacterData Data)
    {
        ClassName = Data.CharacterClassData;
        TraitName = Data.CharacterTraitData;
    }
    
}
