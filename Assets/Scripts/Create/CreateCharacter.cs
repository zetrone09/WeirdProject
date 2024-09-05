using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreateCharacter : MonoBehaviour
{
    public static CreateCharacter Instance;
    public CharacterData characterData;
    public CharacterClassData[] characterClassData;
    public CharacterTraitData[] characterTraitData;
   
    private int sceneBuildIndex = 2;

    [Header("Flags")]
    public bool isNameEntered = false;
    public bool isClassSelected = false;
    public bool isTraitSelected = false;

    private void Awake()
    {
        if (Instance == null){Instance = this;}
        else{ Destroy(Instance);}     
    }
   
    public void CreateCharacterFinish()
    {
        SceneManager.LoadSceneAsync(sceneBuildIndex);
    }
}
