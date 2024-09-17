using UnityEngine;

[ CreateAssetMenu(menuName = "Data/Character/New Character")]
public class CharacterData : ScriptableObject
{
    [Header("Character Name")]
    public string CharacterName;
    public GameObject CharacterModel;

    [Header("Character Heathy Shield and Mana")]
    public int HeathyPoint = 100;
    public int Energy = 0;

    [Header("Character Basic Status")]
    public int BesicPoint = 16;
    public int Strength = 1;
    public int Dexterity = 1;
    public int Intelligence = 1;
    public int WillPower = 1;
    public int Movement = 1;


    public CharacterClassData CharacterClassData;
    public CharacterTraitData CharacterTraitData;
}
