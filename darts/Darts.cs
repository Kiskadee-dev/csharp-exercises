using System;

public static class Darts
{
  enum Scores
  {
    outside = 0,
    outer = 1,
    middle = 5,
    inner = 10
  }
  enum Target
  {
    outer = 10,
    middle = 5,
    inner = 1
  }
  public static int Score(double x, double y)
  {
    double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
    if (distance > (int)Target.outer)
      return (int)Scores.outside;
    if (distance <= (int)Target.inner)
      return (int)Scores.inner;
    if (distance <= (int)Target.middle)
      return (int)Scores.middle;
    if (distance <= (int)Target.outer)
      return (int)Scores.outer;
    return (int)Scores.outer;
  }
}


