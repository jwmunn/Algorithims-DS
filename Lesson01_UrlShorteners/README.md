# URL Shorteners

When sharing a link with a friend have you ever noticed the seemingly random letters and numbers that shortened links are usually made up of?

https://youtu.be/LpuPe81bc2w

In most cases, it's just a base-62 encoded integer! In this assignment, you're being tasked to write a program to convert a base-62 number to base-10 and back again.

Hint: Use an array/string that contains all the numbers and digits: "0123456789AB...YZab...yz". For each letter in the base-62 number, look up the value in the string ("0123456789ABC..."). This gives you the base-62 value for that digit. Keep a running total and remember to keep multiplying by 62.

NOTE: Be careful of overflow issues. The answer contains 20 digits (18,###,###,###,###,###,974) 