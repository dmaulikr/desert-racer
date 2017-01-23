using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TranslateCamera : UnityEngine.MonoBehaviour {
  // The time it takes the elevator to transition between the MainMenu
  // and the GamePlay states.
  float transitionDuration = 2f;

  // The easing function used to transition the camera between the
  // MainMenu and GamePlay states.
  string easingFunction = "CubicInOut";

  // Whether or not we're at the MainMenu
  public bool isOnMainMenu = false;

  FollowPlayer followPlayerScript;

  // This tracks the yPosition of the camera in its two states.
  Dictionary<string, float> yPosition = new Dictionary<string, float>() {
    {"MainMenu", 900f},
    {"GamePlay", 0f}
  };

  // This actually performs the translation, and handles what happens immediately after the translation.
  public IEnumerator TransitionCamera(string location) {
    float endY = yPosition[location];
    Vector3 destination =  new Vector3(transform.position.x, endY, transform.position.z);
    yield return new Vector3Transition(gameObject, destination, transitionDuration, easingFunction);

    if (location == "GamePlay") {
      FollowPlayer();
      isOnMainMenu = false;
    }

    else {
      StopFollowingPlayer();
      isOnMainMenu = true;
    }
  }

  // Attaches the FollowPlayer script to the camera, which makes it track the player's x-coordinates
  void FollowPlayer() {
    followPlayerScript = gameObject.AddComponent<FollowPlayer>() as FollowPlayer;
  }

  // Removes the FollowPlayer script from the camera, so that it stops tracking the player's x-coordinates
  void StopFollowingPlayer() {
    Destroy(followPlayerScript);
  }
}
