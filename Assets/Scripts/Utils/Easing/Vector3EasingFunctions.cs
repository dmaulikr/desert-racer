using UnityEngine;

// Use these just like `UnityEngine.Vector3.Lerp`.
// They're non-linear easing functions.

public class Vector3EasingFunctions {
  // A clone of Vector3.Lerp. It's included for completeness, although it offers no benefits
  // over the built-in version.
  public static Vector3 Lerp(Vector3 a, Vector3 b, float t) {
    t = Mathf.Clamp01(t);
    return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
  }

  public class Quadratic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quadratic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quadratic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quadratic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Cubic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Cubic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Cubic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Cubic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Quartic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quartic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quartic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quartic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Quintic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quintic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quintic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Quintic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Sinusoidal {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Sinusoidal.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Sinusoidal.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Sinusoidal.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Exponential {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Exponential.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Exponential.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Exponential.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Circular {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Circular.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Circular.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Circular.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Elastic {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Elastic.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Elastic.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Elastic.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Back {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Back.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Back.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Back.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }

  public class Bounce {
    public static Vector3 In(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Bounce.In(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 Out(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Bounce.Out(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }

    public static Vector3 InOut(Vector3 a, Vector3 b, float t) {
      t = EasingFunctions.Bounce.InOut(Mathf.Clamp01(t));
      return new Vector3(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t);
    }
  }
}