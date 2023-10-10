
def mergeSort(array):
    l = len(array)

    divide(array, 0, l-1)



def divide(array, left, right):

    if left >= right:
        return
    
    mid = int(left + (right-left)/2)

    divide(array, left, mid)
    divide(array, mid+1, right)
    conquer(array, left, mid, right)



def conquer(array, left, mid, right):

    leftArrayLength = mid-left+1
    rightArrayLength = right-mid

    leftArray = [None] * leftArrayLength
    rightArray = [None] * rightArrayLength

    i=j=0

    for i in range(leftArrayLength):
        leftArray[i] = array[left + i]


    for i in range(rightArrayLength):
        rightArray[i] = array[mid + 1+ i]
    
    i = j = 0
    k = left

    while i < leftArrayLength and j < rightArrayLength:
        if leftArray[i] < rightArray[j]:
            array[k] = leftArray[i]
            i = i+1

        else:
            array[k] = rightArray[j]
            j = j+1
        
        k = k+1

    
    while i < leftArrayLength:
        array[k] = leftArray[i]
        k = k+1
        i = i+1

    while j < rightArrayLength:
        array[k] = rightArray[j]
        k = k+1
        j = j+1


def display(array):
    l = len(array)
    for x in range(l):
        print(array[x])





array = [-2, 45, -12, 11, -9 ]
mergeSort(array)

display(array)