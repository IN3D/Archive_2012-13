Chapter 11: Challenge 01
=====

The goal of this program was to have it take in any number, between 0 and 9,999 and have it print out the English equivalent of it. For example if "123" was entered, the program would print out "One hundred twenty three".

I approached this program by thinking about the structure of numbers in decimal format. the number 7,532 could really be understood as...
7 x 1000
5 x 100
3 x 10
2 x 1

With that in mind, I thought to convert the user given number into a string and then use array notation to access the digits within the number. If statements check the size of the original number, then based on what decimal place the number is at a different function is used.
My aim was to make the code as modular and reusable as a chapter challenge will allow. Each of these functions are used by larger functions, so the resolveHundreds() makes use of the resolveTens() function, reducing the amount of copied code in the program.