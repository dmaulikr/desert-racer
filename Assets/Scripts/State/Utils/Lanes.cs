using UnityEngine;

// This Class contains Static data and methods related to the Lanes,
// which are the different y positions that Racers may occupy.
public class Lanes {
  // The y-position of the first lane, in pixels.
  public static int firstLaneYPosition = 0;
  // The height of a lane in pixels
  public static int Height = 40;
  // The number of lanes in the app
  public static int LaneCount = 4;

  // Increase the `currentLane` by 1.
  public static int IncreaseLane(int currentLane) {
    int newLane = currentLane + 1;
    return Mathf.Clamp(newLane, 0, Lanes.LaneCount - 1);
  }

  // Decrease the `currentLane` by 1.
  public static int DecreaseLane(int currentLane) {
    int newLane = currentLane - 1;
    return Mathf.Clamp(newLane, 0, Lanes.LaneCount - 1);
  }
}
