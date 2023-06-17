# Insert and shift an array in middle at index

The goal for this challenge is to insert a specific value into the middle of an existing array. and shift the rest of the elements.

## Whiteboard Process

![process](./images/Screenshot%202023-06-17%20230636.png)

## Approach & Efficiency

after confirming that the array is null. i will create a new array and make its size to the sent array +1 to store the return value in it and create a loop with the length of the new array. in this for loop i will have 3 cases.

first one is when the iterator is less than the half length of the array fill numbers normally.

second one is when the iterator equals the half length of the array then i inserted the value sent as a param

last case is when the iterator is greater than the half length of the array and in this case the new array will take a
step back in the old array. (newArr[i] = arr[i-1])

space complexity is O(n) since im creating a new array

time complexity is O(n) since im using for loop

## Solution

the function expects an array then a integer value.

![sol](./images/Screenshot%202023-06-17%20223924.png)
