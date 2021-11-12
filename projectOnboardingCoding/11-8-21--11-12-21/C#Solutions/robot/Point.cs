
namespace projectOnboardingCoding
{


  public class Point
  {

    public Point()
    {

    }

    public Point(int latitude, int longitude)
    {
      xPosition = latitude;
      yPosition = longitude;
    }
    public int xPosition { get; set; }

    public int yPosition { get; set; }

    public static string Position(Point x)
    {


      return $"({x.xPosition}, {x.yPosition})";
    }

  }
}