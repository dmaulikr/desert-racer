using UnityEngine;

// This controls a "Racer" object through player input. It's attached
// to the GameObject that displays the player's character.
public class PlayerInput : UnityEngine.MonoBehaviour {
  protected Store store;
  protected Racer racer;

  // How fast the player's car goes
  Vector3 velocity;

  // How long, in milliseconds, it takes this car to change lanes
  //  float changeLaneTime = 500;

  void Start() {
    Debug.Log("Starting");
    this.store = GameObject.Find("_State").GetComponent<Store>();
    this.racer = this.store.player;

    this.velocity = new Vector3(this.racer.speed, 0, 0);
  }

  void Update() {
    this.CheckLaneChange();
    transform.position += velocity * Time.deltaTime;
  }

  // Determine if we need to begin a lane transition, based on key presses
  void CheckLaneChange() {
    if (Input.GetKeyDown(KeyCode.UpArrow)) {
      if (this.racer.ChangeLanes("up")) {
        this.ChangeLane();
      }
    } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
      if (this.racer.ChangeLanes("down")) {
        this.ChangeLane();
      }
    }
  }

  // Actually perform a lane change.
  // TODO: Make this occur over time, using the `changeLaneTime`. Right now,
  // this occurs instantaneously
  void ChangeLane() {
    this.racer.CompleteChangeLanes();
    float newY = Lanes.firstLaneYPosition + (this.racer.lane * Lanes.Height);
    this.transform.position = new Vector3(this.transform.position.x, newY, this.transform.position.z);
  }
}
