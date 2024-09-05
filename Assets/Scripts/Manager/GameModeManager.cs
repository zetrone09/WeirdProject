using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeManager : MonoBehaviour
{
    public ModeState currentModeState;
    public void ChangeModeState()
    {
        if (currentModeState == ModeState.ExplorerMode)
        {
            ChangeModeStateToBattle();

        }
        else if (currentModeState == ModeState.BattleMode)
        {
            ChangeModeStateToExplorer();
        }
    }
    private void ChangeModeStateToExplorer()
    {
        SceneManager.LoadSceneAsync("Explorer_01");
        currentModeState = ModeState.ExplorerMode;
        
    }
    private void ChangeModeStateToBattle()
    {
        SceneManager.LoadSceneAsync("Battle_01");
        currentModeState = ModeState.BattleMode;
        
    }

}
public enum ModeState
{
    ExplorerMode,
    BattleMode
}
