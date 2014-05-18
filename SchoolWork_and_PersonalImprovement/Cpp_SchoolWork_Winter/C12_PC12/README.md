Chapter 12: Challenge 12
=====

This program was very similar to Chapter 11's problem, with the significant modification that the program now needed to handle doubles and not just integers. Smaller modifications included that it needed to take in a name for an employee, and a date. Rather than just the output of the number translated to it's english equivilent. that would now be used in a larger output ment to mimic a paycheck. The layout of the paycheck was provided in the book.

I was very happy I had decided to try and build the first program as sustainable as I could because I did infact end up having to use it again here. I added a resolveDecimal() function to handle the decimal values at the end. The output suggested by the book was something like
"one thousand nine hundred twenty and 85 cents".

as it is ment to mimic a check, it also needed to print out the actual value, and maintain a precision of 2 so that there would always be 2 decimal places after the number, so even if the number entered was just 100, the output would be "$100.00", like it would appear on a real check.