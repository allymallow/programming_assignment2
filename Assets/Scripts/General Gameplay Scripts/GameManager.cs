using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{
    private GameStates _currentGameState;

    public Action<GameStates> OnGameStateChange;

    private bool isPaused;
   /* 
    void Start()
    {
        _currentGameState = GameStates.Start; // setting the initial game state
        OnGameStateChange?.Invoke(_currentGameState);
        Time.timeScale = 0; //Freezing time to allow for start menu
    }

    //Changing the game to "Playing" state, 
   public void Playing()
   {
       Debug.Log("Playing Game");
        _currentGameState = GameStates.Playing;
        OnGameStateChange?.Invoke(_currentGameState);
        Time.timeScale = 1;
    }

    void OnPause(InputValue value)
    {
        if (!value.isPressed) return;
        
        if (value.isPressed)
        {
            _currentGameState = GameStates.Paused;
            OnGameStateChange?.Invoke(_currentGameState);
            Time.timeScale = 0; //freezing time in the game
            
            isPaused = true;
        }
        else
        {
            _currentGameState = GameStates.Playing;
            OnGameStateChange?.Invoke(_currentGameState);
            isPaused = false;
        }
    }

    void GameOver()
    {
        _currentGameState = GameStates.Loss;
        OnGameStateChange?.Invoke(_currentGameState);
        Time.timeScale = 0;
    }

    void WinGame()
    { 
        _currentGameState = GameStates.Win;
        OnGameStateChange?.Invoke(_currentGameState);
        Time.timeScale = 0;
    }
*/
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        
    }
}
