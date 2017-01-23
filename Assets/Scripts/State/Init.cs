using UnityEngine;
using System.Collections;

// This instantiates some of the data that populates the store.
// Right now, this is done on Awake(), but we will probably want to
// adjust that once there's, for instance, a Main Menu.
public class Init : UnityEngine.MonoBehaviour {
  public Store store;
  public GameObject playerGameObject;

  // TODO: Do I really want to do this doing Awake? I'm currently doing
  // it to ensure that the store is configured before anything else's "Start()"
  // script is called. I may need to think about the flow of things when the user
  // clicks "New Game," which would kick off these things.
  void Awake() {
    store = this.gameObject.GetComponent<Store>();
    playerGameObject = GameObject.Find("Player");
  }

  public void CreateNewGame() {
    // Create our Player object
    // First, we need to get the player's width from its sprite.
    SpriteRenderer playerRenderer = playerGameObject.GetComponent<SpriteRenderer>();
    float width = playerRenderer.sprite.rect.size.x;
    Racer player = new Racer(
      name: "Player",
      speed: 40f,
      store: store,
      width: width
    );

    // Add the player to the store, directly and in the `racers` array.
    store.player = player;
    store.racers.Add(player);

    // TODO: Create the 7 other racers
    // Also create anything else that we may need.
  }
}
