using UnityEngine;
using System.Collections;

public class TranslateCamera : UnityEngine.MonoBehaviour {
  public Transform player;

  void Start() {
    this.player = GameObject.Find("Car").transform;
  }

  void Update() {
    
  }

  // The main menu is in the "sky" in the game world. This translates
  // the camera up.
  void MoveToMainMenu() {
  }

  // The game play is beneath the menu, so this translates the camera down.
  void MoveToGamePlay() {
  }
}
