using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // TODO enable gyro or accelerometer
    // TODO create labyrinth with walls
    // TODO Camera sees the labyrinth
    // TODO create key to collect
    // TODO Create UI to show the key collected
    // TODO Make the ball move with the gyroscope gravity
    // TODO after the player collect all the keys, the game is over
    // TODO create a menu to start the game
    // TODO Zoom in and out the camera with two fingers
    // TODO Move camera with fingers

    [SerializeField] private UIManager uiManager;

    public int CollectedDiamondCount => _collectedDiamondCount;
    public bool IsPaused => _isPaused;
    
    private int _collectedDiamondCount = 0;

    private bool _isPaused = false;

    [SerializeField] private int totalDiamondsPlayerHasToCollect = 1;
    
    public void CollectDiamond()
    {
        _collectedDiamondCount++;
        uiManager.UpdateCollectedDiamondText();
        
        if(_collectedDiamondCount == totalDiamondsPlayerHasToCollect)
        {
            uiManager.ShowGameOverPanel();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        _isPaused = true;
        uiManager.ShowPausePanel();
    }
    
    public void ResumeGame()
    {
        _isPaused = false;
        uiManager.HidePausePanel();
    }


}
