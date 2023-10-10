
def sortAscending(array):
    l = len(array)

    quickSortAscending(array, 0, l-1)



def quickSortAscending(array, start, end):
    if start < end:
        partitionIndex = partition(array, start, end)
        quickSortAscending(array, start, partitionIndex-1)
        quickSortAscending(array, partitionIndex+1, end)


def partition(array, start, end):
    pivotValue = array[end]
    partitionIndex = start

    for i in range(start, end):
        if array[i] < pivotValue:
            swap(array, i, partitionIndex)
            partitionIndex = partitionIndex+1

    swap(array, partitionIndex, end)
    return partitionIndex

def swap(array, index1, index2):
    temp = array[index1]
    array[index1] = array[index2]
    array[index2] = temp


def display(array):
    l = len(array)
    for x in range(l):
        print(array[x])





array = [-2, 45, -12, 11, -9 ]
sortAscending(array)

display(array)


