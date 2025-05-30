using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
 public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    void Awake()
    {
        Instance = this;
    }
   private void start()
    {
        UpdateGamestate(GameState.SelectColor);
    }


    public void UpdateGamestate(GameState newstate)
    {
        State = newstate;

        switch (newstate)
        {
            case GameState.SelectColor:
                break;
            case GameState.PlayerTurn:
                break;
            case GameState.EnemyTurn:
                break;
            case GameState.victory:
                break;
            case GameState loose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newstate), newstate, null);
        }
    }
   
}



public enum GameState
{
    SelectColor,
    PlayerTurn,
    EnemyTurn,
    victory,
    loose,
}