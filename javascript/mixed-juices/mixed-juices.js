// @ts-check
//
// The line above enables type checking for this file. Various IDEs interpret
// the @ts-check directive. It will give you helpful autocompletion when
// implementing this exercise.

/**
 * Determines how long it takes to prepare a certain juice.
 *
 * @param {string} name
 * @returns {number} time in minutes
 */
export function timeToMixJuice(name) {
  let time;
  switch (name) {
    case "Pure Strawberry Joy":
      time = 0.5;
      break;
    case "Energizer":
    case "Green Garden":
      time = 1.5;
      break;
    case "Tropical Island":
      time = 3;
      break;
    case "All or Nothing":
      time = 5;
      break;
    default:
      time = 2.5;
  }
  return time;
}

/**
 * Calculates the number of limes that need to be cut
 * to reach a certain supply.
 *
 * @param {number} wedgesNeeded
 * @param {string[]} limes
 * @returns {number} number of limes cut
 */
export function limesToCut(wedgesNeeded, limes) {
  let wedgesPerLime = { small: 6, medium: 8, large: 10 };
  let limesCut = 0;
  let wedgesCut = 0;

  while (wedgesCut < wedgesNeeded && limes.length > 0) {
    const lime = limes.shift();
    wedgesCut += wedgesPerLime[lime];
    limesCut++;
  }
  return limesCut;
}

/**
 * Determines which juices still need to be prepared after the end of the shift.
 *
 * @param {number} timeLeft
 * @param {string[]} orders
 * @returns {string[]} remaining orders after the time is up
 */
export function remainingOrders(timeLeft, orders) {
  do {
    const nextOrderTime = timeToMixJuice(orders[0]);
    orders.shift();
    if (nextOrderTime <= timeLeft) {
      timeLeft -= nextOrderTime;
    } else {
      break;
    }
  } while (timeLeft > 0 && orders.length > 0);
  return orders;
}
