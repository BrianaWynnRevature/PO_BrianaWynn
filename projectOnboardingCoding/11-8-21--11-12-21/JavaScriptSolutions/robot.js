//define a point
class Point {

  constructor(x, y) {
    this.x = x;
    this.y = y;
  }

  static Position(point) {
    return `(${point.x}, ${point.y})`;
  }

}

//Test cases
let north = 20; let east = 30; let south = 10; let west = 40;
let north1 = 0; let east1 = 0;
let north2 = -10; let east2 = 20; let south2 = 10;

console.log(trackRobot(north, east, south, west));
console.log(trackRobot(north1, east1));
console.log(Point.Position(trackRobot(north2, east2, south2)));




//define the trackrobot function

function trackRobot(north, east, south = 0, west = 0) {

  let latitude = east - west;
  let longitude = north - south;

  let point = new Point(latitude, longitude);
  return point;
}

