using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// This holds a public reference to all of the data in this game.
// The intention is that any GameObject in the application can pluck what
// they need. Things that need to read from the data can, and things that
// need to manipulate the data can do that as well.
//
// To access the store from anywhere, you can use:
// GameObject.Find("Store").GetComponent<Store>();
//
// Alternatively, the Init script, which is also attached to the
// State GameObject, can pass it into things via their constructors.
public class Store : UnityEngine.MonoBehaviour {
  // The racer that the player controls
  public Racer player;

  // A list of all of the racers in the game.
  public List<Racer> racers = new List<Racer>();
}
