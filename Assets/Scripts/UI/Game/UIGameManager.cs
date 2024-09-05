using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameManager : MonoBehaviour
{
    public Button EndTurn;
    public Button Surrender;
    private void Awake()
    {
        EndTurn.onClick.AddListener(GameManager.Instance.turnManager.ChangeTurnState);
        Surrender.onClick.AddListener(GameManager.Instance.modeManager.ChangeModeState);
    }
}
