using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBattleInfo : MonoBehaviour
{
    public static UIBattleInfo Instance;
    public Button BattleButton;
    public Button EscapeButton;
    public GameObject BattleInfo;
    private void Awake()
    {
        if (Instance == null)
        { Instance = this; }
        else { Destroy(Instance); }       
    }
    private void Start()
    {
        BattleButton.onClick.AddListener(GameManager.Instance.modeManager.ChangeModeState);
        EscapeButton.onClick.AddListener(CloseBattleInfo);
    }
    public void ShowBattleInfo()
    {
        BattleInfo.SetActive(true);
        GameManager.Instance.turnManager.currentTurnState = TurnState.Waiting;
    }
    void CloseBattleInfo()
    {
        BattleInfo.SetActive(false);
        GameManager.Instance.turnManager.currentTurnState = TurnState.PlayerTurn;
    }
    
}
