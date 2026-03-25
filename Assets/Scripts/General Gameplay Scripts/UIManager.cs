using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
  
    [Header("UI Elements")]
    [SerializeField] private Canvas startCanvas;
    [SerializeField] private Canvas gameOverCanvas;
    [SerializeField] private Canvas pauseCanvas;
    [SerializeField] private Canvas winCanvas;

/* 
    void Awake()
    {
        //Disabling all UI Canvases to start
        startCanvas.gameObject.SetActive(true);
        gameOverCanvas.gameObject.SetActive(false);
        pauseCanvas.gameObject.SetActive(false);
        winCanvas.gameObject.SetActive(false);
    }
  
    void OnEnable()
    {
        gameManager.OnGameStateChange += HandleGameStateChange;
    }

    void OnDisable()
    {
        gameManager.OnGameStateChange -= HandleGameStateChange;
    }

    void HandleGameStateChange(GameStates state)
    {
        startCanvas.gameObject.SetActive(false);
        gameOverCanvas.gameObject.SetActive(false);
        pauseCanvas.gameObject.SetActive(false);
        winCanvas.gameObject.SetActive(false);
    
        switch (state)
        {
            case GameStates.Start:
                startCanvas.gameObject.SetActive(true);
                break;
            case GameStates.Paused:
                pauseCanvas.gameObject.SetActive(true);
                break;
            case GameStates.Playing: 
                break;
            case GameStates.Win:
                winCanvas.gameObject.SetActive(true);
                break;
            case GameStates.Loss:
                gameOverCanvas.gameObject.SetActive(true);
                break;
        }
    }
*/

  
}
