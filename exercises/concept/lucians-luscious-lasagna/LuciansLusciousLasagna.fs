module LuciansLusciousLasagna

let expectedMinutesInOven = 40
let remainingMinutesInOven inOvenMin = expectedMinutesInOven - inOvenMin
let preparationTimeInMinutes numLayer = 2 * numLayer

let elapsedTimeInMinutes numLayer inOvenMin =
    preparationTimeInMinutes numLayer + inOvenMin
