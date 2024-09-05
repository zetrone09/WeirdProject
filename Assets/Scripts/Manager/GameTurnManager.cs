using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTurnManager : MonoBehaviour
{
    public TurnState currentTurnState;
    public void ChangeTurnState()
    {
        if (currentTurnState == TurnState.PlayerTurn)
        {
            ChangeTurnStateToEnemy();
        }
        else if (currentTurnState == TurnState.EnemyTurn)
        {
            ChangeTurnStateToPlayer();
        }
    }
    private void ChangeTurnStateToPlayer()
    {
        currentTurnState = TurnState.PlayerTurn;
    }
    private void ChangeTurnStateToEnemy()
    {
        currentTurnState = TurnState.EnemyTurn;
    }
}
public enum TurnState
{
    PlayerTurn,
    EnemyTurn,
    Waiting
}
