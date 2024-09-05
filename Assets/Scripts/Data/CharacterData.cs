using UnityEngine;

[ CreateAssetMenu(menuName = "Data/Character")]
public class CharacterData : ScriptableObject
{
    [Header("Character Name")]
    public string CharacterName;
    public GameObject CharacterModel;

    [Header("Character Heathy Shield and Mana")]
    public int HeathyPoint;
    public int Shield;

    [Header("Character Basic Status")]
    public int Strength;
    public int Dexterity;
    public int Intelligence;
    public int WillPower;
    public int Movement;


    public CharacterClassData CharacterClassData;
    public CharacterTraitData CharacterTraitData;
}
