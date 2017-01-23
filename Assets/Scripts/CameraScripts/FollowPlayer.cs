using UnityEngine;

// During gameplay, the camera is always centered on the player's racer. This
// script accomplishes that.
// TODO: Dynamically add and remove this from the camera when the game moves between the menu
// and gameplay.
public class FollowPlayer : UnityEngine.MonoBehaviour {
  public Transform target;

  void Start() {
    target = GameObject.Find("Player").transform;
  }

  void Update() {
    // Lock the camera to the player
    this.transform.position = new Vector3(target.position.x, this.transform.position.y, this.transform.position.z);
  }
}
