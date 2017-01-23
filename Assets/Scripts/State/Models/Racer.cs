using UnityEngine;

// This thing stores all of the data for each racer, including the player character.
// It has things like the position, whether its changing lanes, and so on.
// The Racer GameObjects do two things with this data:
//
//   1. they read it to update the visual appearance and location of their sprite
//   2. they write to it to update the racer's state
//
// For the player's Racer, this data is managed by a script that handles user inputs
// to change this info. For the other racers, "AI" scripts manage changing this data.
public class Racer {
  // The name of the racer
  public string name;

  // Whether or not this is the player character
  public bool isPlayer;

  // The x-axis location of the car, in pixels
  public float position;

  // How fast this car moves. Horizontal movement in this game is automatic.
  public float speed;

  // The vertical position of the car. Lanes.cs defines the limitations of this prop.
  public int lane;

  // The next lane that this car will occupy.
  // `-1` means that there is no nextLane. It is only an int when `isChangingLanes` is true.
  public int nextLane;

  // Whether or not the car is stopped. A car gets stopped when it collides with a
  // missile, obstacle, or hole.
  public bool isStopped;

  // Whether or not the car is in the process of switching lanes.
  public bool isChangingLanes;

  // 1st, 2nd, 3rd...the racer's position in the race!
  public int racePlace;

  // The width of the racer in pixels. The Init script will pull this width from the
  // sprite, then set it here.
  float width;

  // This is the number of lanes that the car takes up
  public int height;

  public Store store;

  public Racer(
    Store store,
    float position = 100f,
    string name = "Racer",
    float speed = 100f,
    bool isPlayer = false,
    int nextLane = -1,
    float width = 0
  ) {
    this.store = store;
    this.isPlayer = isPlayer;
    this.position = position;
    this.name = name;
    this.speed = speed;
    this.nextLane = nextLane;
    this.width = width;
  }

  // Direction can be one of "up" or "down". This begins the process of changing the lane.
  // Later, the GameObject should call `racer.CompleteChangeLanes()` to finish the transition.
  // TODO: Check if the lane that they're transitioning to is occupied by a thing? Should that
  // be handled at the data layer? Probably.
  public bool ChangeLanes(string direction) {
    // If a lane change is already underway, then we simply return `false`.
    if (this.isChangingLanes) {
      return false;
    }

    // Determine a possible `nextLane`.
    int nextLane = direction == "up" ? Lanes.IncreaseLane(this.lane) : Lanes.DecreaseLane(this.lane);

    // Check if a car is already in that lane
    bool carIsThere = this.carExistsInLane(nextLane, this.position);

    if (carIsThere) {
      return false;
    }

    // If our current lane is the `nextLane`, then we must be at a boundary. We can't move in
    // this direction, so we return false.
    if (this.lane == nextLane) {
      return false;
    }

    // Otherwise, we set the car to `isChangingLanes`, update our `nextLane`, and return `true`.
    this.isChangingLanes = true;
    this.nextLane = nextLane;
    return true;
  }

  // End a lane transition, if one is currently happening.
  // Returns `true` if a lane change was in progress; `false` otherwise.
  public bool CompleteChangeLanes() {
    // If we're not changing lanes, then there's nothing to do.
    if (!this.isChangingLanes) {
      return false;
    }

    // If we're currently changing lanes, then we set the `nextLane` to be the current lane,
    // then clear that value. We also set `isChangingLanes` to be false.
    this.isChangingLanes = false;
    this.lane = this.nextLane;
    this.nextLane = -1;
    return true;
  }

  // Pass in a xPosition and a lane to see if there's a car there. Useful to prevent cars from
  // merging lanes with another car.
  // TODO: Determine the width of the cars, and use that to check if the car overlaps with the xPos
  // that's passed in.
  public bool carExistsInLane(int lane, float xPos) {
    bool doesCarExist = false;

    this.store.racers.ForEach(delegate(Racer racer) {
      Debug.Log(string.Format("Checking out: {0}", racer.name));
    });

    return doesCarExist;
  }
}
