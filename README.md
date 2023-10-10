# sorting

Selection Sort: In this sorting technique, we  iterate over the elements of the array, for each iteration we pick the current element and compare it with all the remaining elements of the array to check the smallest. Once we have the smallest or the index of the smallest element, we replace it with the current element of the iteration. We keep doing this and get a sorted element.
Time Complexity - as we have a nested loop, the complexity if O(n2)



Bubble Sort: In this sorting technique, we iterate over the elements of the array and compare item at Ith location with item at (I+1)th location. If they are not sorted then we swap them, else we continue. After the iterations are complete the array is sorted.
After each iteration, the array towards the end(right side) is getting sorted.
Time Complexity - As we are running two loops in nested way, then the worst possible iterations count is n*n.
So, time complexity is O(n*n) = O(n2)

We can improve it slightly, but not always going till the end of array in every iteration(as we know that the end part keeps getting sorted after every iteration) and also by adding a flag which tells us that the current iteration did not do any swap, in this case we can terminate the furthure iterations). Even though we do all this, the complexity still remains O(n2) as it is considered on the worst case scenario.


Insertion Sort: This sorting technique works on the concept of inserting the correct value at its loction and shifting the remainining unsorted values to the right. In this technique, we sort the array from left to right. We take each value and keep checking it to all the values on the left, till we find its correct position, we then move all the values on the right one index more right and insert the current values at its specified location
Time Complexity - O(n2)


Merge Sort - This technique works on DIVIDE AND CONQUER statergy. We divide our array to its smallest form(length = 2) and then we build up by sorting and merging the same to make the final array
Time Complexity - O(n log n)
Assuming the length of the array is N, every time we divide it into equal halves, we can represent that process as a logarithmic function log N. In each step, we find the middle of any subarray, which takes O(1) time. 

As we merge the subarrays, the algorithm takes O(N) which we determine through the length of the array we are sorting.


Quick Sort - In this sorting technique, we pick a pivot(usually the last element of the array) and partition(arrange) the whole array in a way that the left of this pivot element is all smaller and to the right it bigger. We keep doing this in a loop and the outcome is a sorted array.
Although, the time complexity of this technique is O(nlogn) is best case and O(n2) in worst case but it is a bit better then merge sort as it is an in-place sorting technique, which means that it does not use another array for sorting.