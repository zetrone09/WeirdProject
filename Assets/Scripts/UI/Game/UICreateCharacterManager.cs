using UnityEngine.UI;
using UnityEngine;

public class UICreateCharacterManager : MonoBehaviour
{
    public Button[] classSelectButton;
    public Button[] traitSelectButton;
    public Button playButton;

    [SerializeField] private string characterName;
    public Color selectedColor = Color.green;
    public Color unselectedColor = Color.white;
    void Start()
    {
        playButton.interactable = false;      
    }
    public void GetNameInput(string inputName)
    {
        characterName = inputName;
        SetName(inputName);
    }
    private void SetName(string inputName)
    {
        CreateCharacter.Instance.characterData.CharacterName = characterName;
        if (CreateCharacter.Instance.characterData.CharacterName != null)
        {
            CreateCharacter.Instance.isNameEntered = true;
            UpdatePlayButtonState();
        }
    }
    public void GetClass(int index)
    {
        CreateCharacter.Instance.characterData.CharacterClassData = CreateCharacter.Instance.characterClassData[index];
        SetClass(index);
        Debug.Log("Selected Weapon: " + CreateCharacter.Instance.characterData.CharacterClassData.ClassName);        
    }
    private void SetClass(int index)
    {
        CreateCharacter.Instance.isClassSelected = true;
        for (int i = 0; i < classSelectButton.Length; i++)
        {
            ColorBlock colors = classSelectButton[i].colors;
            if (i == index)
            {
                colors.normalColor = selectedColor;
            }
            else
            {
                colors.normalColor = unselectedColor;
            }
            classSelectButton[i].colors = colors;
        }
        UpdatePlayButtonState();
    }
    public void GetTraits(int index)
    {
        
            CreateCharacter.Instance.characterData.CharacterTraitData = CreateCharacter.Instance.characterTraitData[index];
            SetTrait(index);
            Debug.Log("Selected Traits: " + CreateCharacter.Instance.characterData.CharacterTraitData.TraitName);
        
    }
    private void SetTrait(int index)
    {
        CreateCharacter.Instance.isTraitSelected = true;
        for (int i = 0; i < traitSelectButton.Length; i++)
        {
            ColorBlock colors = traitSelectButton[i].colors;
            if (i == index)
            {
                colors.normalColor = selectedColor;
            }
            else
            {
                colors.normalColor = unselectedColor;
            }
            traitSelectButton[i].colors = colors;
        }
        UpdatePlayButtonState();
    }   
    void UpdatePlayButtonState()
    {
        playButton.interactable = CreateCharacter.Instance.isNameEntered && 
                                  CreateCharacter.Instance.isClassSelected && 
                                  CreateCharacter.Instance.isTraitSelected;
        playButton.onClick.AddListener(CreateCharacter.Instance.CreateCharacterFinish);
    }
}
