// author: Zachary woolfolk

function roam() {
  let x = 0;
  let y = 0;
  let facing = 0; //0 = North, 1 = East, 2 = South, 3 = West

  for (let i = 0; i < arguments.length; i++) {

    if (facing > 3) {
      facing = 0;
    }

    if (facing == 0) {
      y = y + arguments[i];
      facing++;
    }
    else if (facing == 1) {
      x = x + arguments[i];
      facing++;
    }
    else if (facing == 2) {
      y = y - arguments[i];
      facing++;
    }
    else {
      x = x - arguments[i];
      facing++;
    }

  }

  return "The robot's final position is (" + x + ", " + y + ").";

}

console.log(roam(20, 30, 10, 40));
console.log(roam(30, 50, 15));
console.log(roam());
console.log(roam(10, 10, 10, 10, 10, 20));