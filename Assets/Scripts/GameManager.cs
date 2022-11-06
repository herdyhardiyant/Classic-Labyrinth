using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

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
