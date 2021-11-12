
namespace projectOnboardingCoding
{

  public class TrackRobot
  {
    public static Point trackRobot(int north, int east, int south = 0, int west = 0)
    {

      int latitude = east - west;
      int longitude = north - south;

      Point point = new Point(latitude, longitude);

      return point;
    }
  }
}
