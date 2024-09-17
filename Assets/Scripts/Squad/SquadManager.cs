using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SquadManager : MonoBehaviour
{
    public List<CharacterData> squadMembers = new List<CharacterData>();
    public List<CharacterData> characterInSquad;
    public List<Transform> playerTranstorm;
    private float spacing = 1f;
    private void Awake()
    {
        foreach (CharacterData character in characterInSquad)
        {
            AddCharacterToSquad(character);          
        }

        playerTranstorm.Add(GameObject.Find("Player Manager").transform);             
    }
    private void Start()
    {
        if (GameManager.Instance.modeManager.currentModeState == ModeState.ExplorerMode)
        {
            InstantiateCharacterInExplorerMode(characterInSquad, playerTranstorm);
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
    public void InstantiateCharacterInExplorerMode(List<CharacterData> characters, List<Transform> playerTranstorm)
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

            GameObject newCharacter = Instantiate(characters[i].CharacterModel, spwanpoint, Quaternion.identity, playerTranstorm[0]);
            newCharacter.name = character.CharacterName;
        }      
    }
}
