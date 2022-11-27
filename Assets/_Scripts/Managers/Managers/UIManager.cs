using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{

  #region Fields
  [SerializeField] private GameObject EndGamePanels;
  [SerializeField] private GameObject LevelCompletedPanel;
  [SerializeField] private GameObject LevelFailedPanel;
  #endregion

  #region Components
  private GameManager _gameManager;
  #endregion

  #region Unity Functions
  private void Start()
  {

  }

  private void OnEnable()
  {
    _gameManager = ManagerContainer.Instance.GetInstance<GameManager>();
  }

  private void OnDisable()
  {

  }
  #endregion

  #region UI Functions
  public void UIF_RestartGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }

  public void UIF_QuitGame()
  {
    Application.Quit();
  }

  #endregion

  #region UI Update

  public void ActivateEndGameMenu(bool condition)
  {
    EndGamePanels.SetActive(true);
    
    switch ( condition )
    {
      case false:
        LevelFailedPanel.SetActive(true);
        break;
      case true:
        LevelCompletedPanel.SetActive(true);
        break;
    }
  }

  #endregion

}
