using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameModeManager modeManager;
    public GameTurnManager turnManager;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        modeManager = GetComponent<GameModeManager>();
        turnManager = GetComponent<GameTurnManager>();
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}

