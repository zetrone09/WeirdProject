using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShowModelCharacter : MonoBehaviour
{
    public List<GameObject> CharacterModel = new List<GameObject>();
    private GameObject currentCharacterModel;
    public int ModelIndex = 0;
    public Button NextModelButton;
    public Button PrevModelButton;
    private bool isShowModel = false;
    private void Start()
    {
        NextModelButton.onClick.AddListener(NextModel);
        PrevModelButton.onClick.AddListener(PrevModel);
    }
    private void Update()
    {
        if (!isShowModel)
        {
            ShowModel(CharacterModel, ModelIndex);
        }        
    }
    void ShowModel(List<GameObject> CharacterModel,int Index)
    {
        if (currentCharacterModel != null)
        {
            Destroy(currentCharacterModel);
        }

        currentCharacterModel = Instantiate(CharacterModel[Index], Vector3.zero,Quaternion.identity);

        CreateCharacter.Instance.characterData.CharacterModel = CharacterModel[Index];

        isShowModel = true;
    }
    void NextModel() 
    {
        isShowModel = false;
   
        if (ModelIndex <= CharacterModel.Count - 1)
        {
            ModelIndex++;
        }

        if (ModelIndex > CharacterModel.Count - 1)
        {
            ModelIndex = 0;
        }


    }
    void PrevModel() 
    {
        isShowModel = false;
        
        if (ModelIndex >= 0) 
        {
            ModelIndex--;
        }

        if (ModelIndex < 0)
        {
            ModelIndex = CharacterModel.Count - 1;
        }

    }
}
