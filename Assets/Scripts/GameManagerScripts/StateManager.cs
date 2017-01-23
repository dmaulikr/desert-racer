using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This script manages the set up and teardown of data
// necessary to start and load games. It's mostly
// an interface to the _State and its Store GameObject.
public class StateManager : UnityEngine.MonoBehaviour {
  GameObject storeObject;
  Store store;
  Init init;
  TranslateCamera translateCamera;
  GameObject player;
  PlayerInput playerInputScript;

  void Start() {
    storeObject = GameObject.Find("_State");
    player = GameObject.Find("Player");
    translateCamera = GameObject.Find("Main Camera").GetComponent<TranslateCamera>();
    store = storeObject.GetComponent<Store>();
    init = storeObject.GetComponent<Init>();
  }

  public void StartGame() {
    StartCoroutine("_StartGame");
  }

  IEnumerator _StartGame() {
    // First, start by setting up the database
    init.CreateNewGame();

    // Next, we transition the camera
    yield return translateCamera.TransitionCamera("GamePlay");

    // Lastly, we make the game interactive by adding the playerInput script to the
    // player's racer.
    playerInputScript = player.AddComponent<PlayerInput>() as PlayerInput;
  }

  public void ExitGameMode() {
    Destroy(playerInputScript);
  }
}
