using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SquadManager : MonoBehaviour
{
    public List<CharacterData> squadMembers = new List<CharacterData>();
    public List<CharacterData> characterInSquad;

    private float spacing = 1f;
    private void Awake()
    {
        foreach (CharacterData character in characterInSquad)
        {
            AddCharacterToSquad(character);          
        }
        if (GameManager.Instance.modeManager.currentModeState == ModeState.ExplorerMode)
        {
            InstantiateCharacterInExplorerMode(squadMembers);
        }
                     
    }
    private void AddCharacterToSquad(CharacterData character)
    {
        if (!squadMembers.Contains(character) && squadMembers.Count < characterInSquad.Count)
        {
            squadMembers.Add(character);        
        }
    }
    private void RemoveCharacterFromSquad(CharacterData character)
    {
        if (squadMembers.Contains(character))
        {
            squadMembers.Remove(character);
            Destroy(character);
        }
    }
    public void InstantiateCharacterInExplorerMode(List<CharacterData> characters)
    {
        if (characters.Count != characterInSquad.Count)
        {
            Debug.LogWarning("Number of characters does not match number of spawn points.");
            return;
        }
        for (int i = 0; i < characterInSquad.Count; i++)
        {
            CharacterData character = characters[i];

            Vector3 spwanpoint = new Vector3(i*spacing,0,0);

            GameObject newCharacter = Instantiate(characters[i].CharacterModel, spwanpoint, Quaternion.identity);
            newCharacter.name = character.CharacterName;
        }      
    }
}
