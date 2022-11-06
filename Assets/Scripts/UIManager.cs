using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text collectDiamondsText;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pausePanel;

    private void Awake()
    {
        collectDiamondsText.text = "Diamonds: " + 0;
        pausePanel.SetActive(false);
        gameOverPanel.SetActive(false);
    }
    
    public void UpdateCollectedDiamondText()
    {
        collectDiamondsText.text = "Diamonds: " + gameManager.CollectedDiamondCount;
    }
    
    public void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }
    
    public void ShowPausePanel()
    {
        pausePanel.SetActive(true);
    }

    public void HidePausePanel()
    {
        pausePanel.SetActive(false);

    }
}
