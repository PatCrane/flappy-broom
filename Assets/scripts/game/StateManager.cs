using System;
using UnityEditor;
using UnityEngine;



public enum GameState { Start, Playing, Continue, GameOver } //Game States

public class StateManager : MonoBehaviour
{
    public static StateManager instance;
    public GameState currentState;
    [SerializeField] bool isDevelopmentMode;

    //Game state events. 
    public static event Action OnGameOver;
    public static event Action OnGamePlaying;
    public static event Action OnGameContinue;
    public static event Action OnGameStart;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    //Set default game state
    void Start()
    {
        ChangeState(GameState.Start);
        OnGameStart?.Invoke();
    }

    //Event Handlers
    private void GameStateOnMobCollision()
    {
        ChangeState(GameState.GameOver);
        OnGameOver?.Invoke();
    }

    //Event subscriptions
    private void OnEnable()
    {
        MobCollision.OnMobCollision += GameStateOnMobCollision;
    }

    private void OnDisable()
    {
        MobCollision.OnMobCollision -= GameStateOnMobCollision;
    }


    public void ChangeState(GameState newState)
    {
        currentState = newState;

        switch (currentState) 
        {
            case GameState.Start:
                Debug.Log("GAMESTATE = START");
                break;

            case GameState.Playing:
                Debug.Log("GAMESTATE = PLAYING");
                break;

            case GameState.Continue:
                Debug.Log("GAMESTATE = CONTINUE");
                break;

            case GameState.GameOver:
                Debug.Log("GAMESTATE = GAME OVER");
                break;
        }
    }
   
}


