using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillNumber : MonoBehaviour
{
  private HealthComponent _HealthComponent;
  public int Score;
  public TextMeshProUGUI ScoreText;
  private void Awake()
  {
    Score = _HealthComponent.number;
  }

  void Update()
  {
    ScoreText.text = Score.ToString();
  }
}
