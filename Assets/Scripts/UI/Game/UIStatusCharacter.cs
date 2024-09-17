using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatusCharacter : MonoBehaviour
{
    public TMP_Text statusPoint;
    [Header("Strength Status")]
    public TMP_Text statusStrength;
    public Button plusStrengthButton;
    public Button minusStrengthButton;

    [Header("Dexterity Status")]
    public TMP_Text statusDexterity;
    public Button plusDexterityButton;
    public Button minusDexterityButton;

    [Header("Intelligence Status")]
    public TMP_Text statusIntelligence;
    public Button plusIntelligenceButton;
    public Button minusIntelligenceButton;

    [Header("WillPower Status")]
    public TMP_Text statusWillPower;
    public Button plusWillPowerButton;
    public Button minusWillPowerButton;
    private void Start()
    {
        plusStrengthButton.onClick.AddListener(plusStrength);
        minusStrengthButton.onClick.AddListener(minusStrength);

        plusDexterityButton.onClick.AddListener(plusDexterity);
        minusDexterityButton.onClick.AddListener(minusDexterity);

        plusIntelligenceButton.onClick.AddListener(plusIntelligence);
        minusIntelligenceButton.onClick.AddListener(minusIntelligence);

        plusWillPowerButton.onClick.AddListener(plusWillPower);
        minusWillPowerButton.onClick.AddListener(minusWillPower);
    }
    private void Update()
    {
        UpdateStatusPoint();
    }
    private void UpdateStatusPoint()
    {
        statusPoint.text = CreateCharacter.Instance.characterData.BesicPoint.ToString();
        statusStrength.text = CreateCharacter.Instance.characterData.Strength.ToString();
        statusDexterity.text = CreateCharacter.Instance.characterData.Dexterity.ToString();
        statusIntelligence.text = CreateCharacter.Instance.characterData.Intelligence.ToString();
        statusWillPower.text = CreateCharacter.Instance.characterData.WillPower.ToString();
    }
    private void plusStrength()
    {
        if (CreateCharacter.Instance.characterData.Strength <= 16 && CreateCharacter.Instance.characterData.BesicPoint > 0)
        {
            CreateCharacter.Instance.characterData.BesicPoint--;
            CreateCharacter.Instance.characterData.Strength++;
            UpdateStatusPoint();
        }
    }
    private void minusStrength() 
    {
        if (CreateCharacter.Instance.characterData.Strength > 1 && CreateCharacter.Instance.characterData.BesicPoint < 16)
        {
            CreateCharacter.Instance.characterData.BesicPoint++;
            CreateCharacter.Instance.characterData.Strength--;
            UpdateStatusPoint();
        }
    }
    private void plusDexterity()
    {
        if (CreateCharacter.Instance.characterData.Dexterity <= 16 && CreateCharacter.Instance.characterData.BesicPoint > 0)
        {
            CreateCharacter.Instance.characterData.BesicPoint--;
            CreateCharacter.Instance.characterData.Dexterity++;
            UpdateStatusPoint();
        }
    }
    private void minusDexterity() 
    {
        if (CreateCharacter.Instance.characterData.Dexterity > 1 && CreateCharacter.Instance.characterData.BesicPoint < 16)
        {
            CreateCharacter.Instance.characterData.BesicPoint++;
            CreateCharacter.Instance.characterData.Dexterity--;
            UpdateStatusPoint();
        }
    }
    private void plusIntelligence()
    {
        if (CreateCharacter.Instance.characterData.Intelligence <= 16 && CreateCharacter.Instance.characterData.BesicPoint > 0)
        {
            CreateCharacter.Instance.characterData.BesicPoint--;
            CreateCharacter.Instance.characterData.Intelligence++;
            UpdateStatusPoint();
        }
    }
    private void minusIntelligence() 
    {
        if (CreateCharacter.Instance.characterData.Intelligence > 1 && CreateCharacter.Instance.characterData.BesicPoint < 16)
        {
            CreateCharacter.Instance.characterData.BesicPoint++;
            CreateCharacter.Instance.characterData.Intelligence--;
            UpdateStatusPoint();
        }
    }
    private void plusWillPower() 
    {
        if (CreateCharacter.Instance.characterData.WillPower <= 16 && CreateCharacter.Instance.characterData.BesicPoint > 0)
        {
            CreateCharacter.Instance.characterData.BesicPoint--;
            CreateCharacter.Instance.characterData.WillPower++;
            UpdateStatusPoint();
        }
    }
    private void minusWillPower() 
    {
        if (CreateCharacter.Instance.characterData.WillPower > 1 && CreateCharacter.Instance.characterData.BesicPoint < 16)
        {
            CreateCharacter.Instance.characterData.BesicPoint++;
            CreateCharacter.Instance.characterData.WillPower--;
            UpdateStatusPoint();
        }
    }

}
