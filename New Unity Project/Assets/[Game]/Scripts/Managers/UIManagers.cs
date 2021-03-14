using System;
using System.Collections;
using System.Collections.Generic;
using Runner.Managers;
using Runner.Player;
using TMPro;
using UnityEngine;

public class UIManagers : MonoBehaviour
{
  [SerializeField] private TextMeshProUGUI _scoreTxt;
  [SerializeField] private PlayerSettings _playerSettings;
  [SerializeField] private GameObject _gameOverPanel;
  [SerializeField] private TextMeshProUGUI _gameOverScore;

  private void OnEnable()
  {
    EventManager.AddShuriken += ItemShuriken;
    EventManager.IsObstacleHit += GameOver;
  }

  private void OnDisable()
  {
    EventManager.AddShuriken -= ItemShuriken;
    EventManager.IsObstacleHit -= GameOver;
  }

  private void ItemShuriken()
  {
    _scoreTxt.SetText(GameManager.ShurikenAmount.ToString());
  }

  private void GameOver()
  {
    _playerSettings.Speed = 0;
    _gameOverPanel.SetActive(true);
    _gameOverScore.SetText("Score:"+ GameManager.ShurikenAmount);
    
    
  }
}
