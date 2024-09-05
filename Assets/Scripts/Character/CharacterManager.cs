using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : Character
{
    [Header("Character Data")]
    CharacterDataManager characterDataManager;

    [Header("Character Logic")]
    CharacterMotionManager characterMotionManager;
    protected override void Awake()
    {
        base.Awake();
        characterDataManager = GetComponent<CharacterDataManager>();
        characterMotionManager = GetComponent<CharacterMotionManager>();
    }
}
