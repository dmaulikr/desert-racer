// What these do is take a number between 0 and 1 and map it to an easing
// function. For instance, Linear just returns the value. But using
// any other function will have a different progression curve. These can be
// used as the basis for custom Lerp methods.

// These were sourced from:
// https://gist.github.com/Fonserbc/3d31a25e87fdaa541ddf
// which in turn sourced from Tween.js

public class EasingFunctions {
  public static float Linear (float k) {
    return k;
  }

  public class Quadratic {
    public static float In (float k) {
      return k*k;
    }

    public static float Out (float k) {
      return k*(2f - k);
    }

    public static float InOut (float k) {
      if ((k *= 2f) < 1f) return 0.5f*k*k;
      return -0.5f*((k -= 1f)*(k - 2f) - 1f);
    }   
  };

  public class Cubic {   
    public static float In (float k) {
      return k*k*k;
    }

    public static float Out (float k) {
      return 1f + ((k -= 1f)*k*k);
    }

    public static float InOut (float k) {
      if ((k *= 2f) < 1f) return 0.5f*k*k*k;
      return 0.5f*((k -= 2f)*k*k + 2f);
    }
  };

  public class Quartic {   
    public static float In (float k) {
      return k*k*k*k;
    }

    public static float Out (float k) {
      return 1f - ((k -= 1f)*k*k*k);
    }

    public static float InOut (float k) {
      if ((k *= 2f) < 1f) return 0.5f*k*k*k*k;
      return -0.5f*((k -= 2f)*k*k*k - 2f);
    }   
  };

  public class Quintic {   
    public static float In (float k) {
      return k*k*k*k*k;
    }

    public static float Out (float k) {
      return 1f + ((k -= 1f)*k*k*k*k);
    }

    public static float InOut (float k) {
      if ((k *= 2f) < 1f) return 0.5f*k*k*k*k*k;
      return 0.5f*((k -= 2f)*k*k*k*k + 2f);
    }   
  };

  public class Sinusoidal {   
    public static float In (float k) {
      return 1f - UnityEngine.Mathf.Cos(k*UnityEngine.Mathf.PI/2f);
    }

    public static float Out (float k) {
      return UnityEngine.Mathf.Sin(k*UnityEngine.Mathf.PI/2f);
    }

    public static float InOut (float k) {
      return 0.5f*(1f - UnityEngine.Mathf.Cos(UnityEngine.Mathf.PI*k));
    }   
  };

  public class Exponential {   
    public static float In (float k) {
      return k == 0f? 0f : UnityEngine.Mathf.Pow(1024f, k - 1f);
    }

    public static float Out (float k) {
      return k == 1f? 1f : 1f - UnityEngine.Mathf.Pow(2f, -10f*k);
    }

    public static float InOut (float k) {
      if (k == 0f) return 0f;
      if (k == 1f) return 1f;
      if ((k *= 2f) < 1f) return 0.5f*UnityEngine.Mathf.Pow(1024f, k - 1f);
      return 0.5f*(-UnityEngine.Mathf.Pow(2f, -10f*(k - 1f)) + 2f);
    }   
  };

  public class Circular {   
    public static float In (float k) {
      return 1f - UnityEngine.Mathf.Sqrt(1f - k*k);
    }

    public static float Out (float k) {
      return UnityEngine.Mathf.Sqrt(1f - ((k -= 1f)*k));
    }

    public static float InOut (float k) {
      if ((k *= 2f) < 1f) return -0.5f*(UnityEngine.Mathf.Sqrt(1f - k*k) - 1);
      return 0.5f*(UnityEngine.Mathf.Sqrt(1f - (k -= 2f)*k) + 1f);
    }   
  };

  public class Elastic {
    public static float In (float k) {
      if (k == 0) return 0;
      if (k == 1) return 1;
      return -UnityEngine.Mathf.Pow( 2f, 10f*(k -= 1f))*UnityEngine.Mathf.Sin((k - 0.1f)*(2f*UnityEngine.Mathf.PI)/0.4f);
    }

    public static float Out (float k) {
      if (k == 0) return 0;
      if (k == 1) return 1;
      return UnityEngine.Mathf.Pow(2f, -10f*k)*UnityEngine.Mathf.Sin((k - 0.1f)*(2f*UnityEngine.Mathf.PI)/0.4f) + 1f;
    }

    public static float InOut (float k) {
      if ((k *= 2f) < 1f) return -0.5f*UnityEngine.Mathf.Pow(2f, 10f*(k -= 1f))*UnityEngine.Mathf.Sin((k - 0.1f)*(2f*UnityEngine.Mathf.PI)/0.4f);
      return UnityEngine.Mathf.Pow(2f, -10f*(k -= 1f))*UnityEngine.Mathf.Sin((k - 0.1f)*(2f*UnityEngine.Mathf.PI)/0.4f)*0.5f + 1f;
    }   
  };

  public class Back {
    static float s = 1.70158f;
    static float s2 = 2.5949095f;

    public static float In (float k) {
      return k*k*((s + 1f)*k - s);
    }

    public static float Out (float k) {
      return (k -= 1f)*k*((s + 1f)*k + s) + 1f;
    }

    public static float InOut (float k) {
      if ((k *= 2f) < 1f) return 0.5f*(k*k*((s2 + 1f)*k - s2));
      return 0.5f*((k -= 2f)*k*((s2 + 1f)*k + s2) + 2f);
    }   
  };

  public class Bounce {   
    public static float In (float k) {
      return 1f - Out(1f - k);
    }

    public static float Out (float k) {     
      if (k < (1f/2.75f)) {
        return 7.5625f*k*k;       
      }
      else if (k < (2f/2.75f)) {
        return 7.5625f*(k -= (1.5f/2.75f))*k + 0.75f;
      }
      else if (k < (2.5f/2.75f)) {
        return 7.5625f *(k -= (2.25f/2.75f))*k + 0.9375f;
      }
      else {
        return 7.5625f*(k -= (2.625f/2.75f))*k + 0.984375f;
      }
    }

    public static float InOut (float k) {
      if (k < 0.5f) return In(k*2f)*0.5f;
      return Out(k*2f - 1f)*0.5f + 0.5f;
    }   
  };
}