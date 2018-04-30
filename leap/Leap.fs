module Leap
let isDivisibleBy(modulus: int)(number: int): bool = number % modulus = 0
let leapYear (year: int): bool = isDivisibleBy 400 year || isDivisibleBy 4 year && not (isDivisibleBy 100 year)