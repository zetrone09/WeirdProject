using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataManager : MonoBehaviour
{
    [Header("Character Info")]
    public CharacterData characterData;
    [SerializeField] private CharacterClassData ClassName;
    [SerializeField] private CharacterTraitData TraitName;

   
    private void Start()
    {     
        InitializeCharacterData(characterData);
    }

    void InitializeCharacterData(CharacterData Data)
    {
        ClassName = Data.CharacterClassData;
        TraitName = Data.CharacterTraitData;
    }
    
}
