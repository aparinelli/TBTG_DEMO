using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentMenu : MonoBehaviour
{
  public static EquipmentMenu Instance { get; private set; }

  private void Awake() {
    Instance = this;
  }
  
  void Start()
  {
    Close();
  }

  public void Open()
  {
    gameObject.SetActive(true);
    Time.timeScale = 0f; // Pause the game
  }

  public void Close()
  {
    gameObject.SetActive(false);
    Time.timeScale = 1f; // Resume the game
  }

  // Add methods to handle equipment logic here
}