## Data Structures, Algorithms and Complexity Homework

1. O(n^2)
    * For every element in the for loop we will run every element in the while loop.

1.  O(n*m)
    * For every element "n" in the first for loop we might run every element "m" in the second loop. Which is worst case scenario.

1.  O(n*m!)
    * For every "n" matrix column we will calculate sum then we will run recursively the same method for every "m" matrix row. For example, first time if row = 0, recursion with row=1, then with row =2 etc. until row reaches "m"