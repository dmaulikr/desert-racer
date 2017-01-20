using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

// Transitions a Vector3 over time. Intended to be used within a Coroutine.
// For instance:
//
// SomeCoroutine() {
//   yield return new Vector3Transition(this, dest, 5f);
// }
//
// Pass in a fourth argument, "easingFunction", to specify a different easing
// function other than Vector3.Lerp
public class Vector3Transition : IEnumerator {
  // The GameObject being moved
  GameObject target;

  // The initial position of that game object
  Vector3 initial;

  // The Vector3 end destination
  Vector3 destination;

  // How long the animation should last
  float duration;

  // How far this animation has progressed. Goes between 0 and 1.
  float progress = 0;

  // How much time has passed in this animation
  float totalTime = 0;

  // The value of Time.time for the previous frame of this animation
  float lastTime;

  Func<Vector3, Vector3, float, Vector3> easing;

  // These are the options for easing functions. They map to functions in Vector3EasingFunctions.cs
  Dictionary<string, Func<Vector3, Vector3, float, Vector3>> easingFunctions =
    new Dictionary<string, Func<Vector3, Vector3, float, Vector3>> {
    { "Linear", Vector3EasingFunctions.Lerp },
    { "QuadraticIn", Vector3EasingFunctions.Quadratic.In },
    { "QuadraticOut", Vector3EasingFunctions.Quadratic.Out },
    { "QuadraticInOut", Vector3EasingFunctions.Quadratic.InOut },
    { "CubicIn", Vector3EasingFunctions.Cubic.In },
    { "CubicOut", Vector3EasingFunctions.Cubic.Out },
    { "CubicInOut", Vector3EasingFunctions.Cubic.InOut },
    { "QuarticIn", Vector3EasingFunctions.Quartic.In },
    { "QuarticOut", Vector3EasingFunctions.Quartic.Out },
    { "QuarticInOut", Vector3EasingFunctions.Quartic.InOut },
    { "QuinticIn", Vector3EasingFunctions.Quintic.In },
    { "QuinticOut", Vector3EasingFunctions.Quintic.Out },
    { "QuinticInOut", Vector3EasingFunctions.Quintic.InOut },
    { "SinusoidalIn", Vector3EasingFunctions.Sinusoidal.In },
    { "SinusoidalOut", Vector3EasingFunctions.Sinusoidal.Out },
    { "SinusoidalInOut", Vector3EasingFunctions.Sinusoidal.InOut },
    { "ExponentialIn", Vector3EasingFunctions.Exponential.In },
    { "ExponentialOut", Vector3EasingFunctions.Exponential.Out },
    { "ExponentialInOut", Vector3EasingFunctions.Exponential.InOut },
    { "CircularIn", Vector3EasingFunctions.Circular.In },
    { "CircularOut", Vector3EasingFunctions.Circular.Out },
    { "CircularInOut", Vector3EasingFunctions.Circular.InOut },
    { "ElasticIn", Vector3EasingFunctions.Elastic.In },
    { "ElasticOut", Vector3EasingFunctions.Elastic.Out },
    { "ElasticInOut", Vector3EasingFunctions.Elastic.InOut },
    { "BackIn", Vector3EasingFunctions.Back.In },
    { "BackOut", Vector3EasingFunctions.Back.Out },
    { "BackInOut", Vector3EasingFunctions.Back.InOut },
    { "BounceIn", Vector3EasingFunctions.Bounce.In },
    { "BounceOut", Vector3EasingFunctions.Bounce.Out },
    { "BounceInOut", Vector3EasingFunctions.Bounce.InOut }
  };

  public Vector3Transition(GameObject obj, Vector3 dest, float time, string easingFunction = "Linear") {
    target = obj;
    initial = obj.transform.position;
    duration = time;
    destination = dest;
    easing = easingFunctions[easingFunction];

    // We set the "last time" to be the current time, as this is the start of the animation.
    lastTime = Time.time;
  }

  public bool MoveNext() {
    // The current progress is how much time has passed divided by the duration, which is the
    // total time. This should be roughly between 0 and 1.
    progress = totalTime / duration;

    // We use our easing function to find the current position
    target.transform.position = easing(initial, destination, progress);

    // Update the total time with however much time has passed since our lastTime.
    totalTime += Time.time - lastTime;

    lastTime = Time.time;
    return progress < 1;
  }

  // Intentionally blank
  public void Reset() {}

  // Intentionally null
  object IEnumerator.Current {
    get {
      return null;
    }
  }
}