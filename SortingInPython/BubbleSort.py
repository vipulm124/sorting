
def sortAscending(array):
    l = len(array)
    for i in range(l-1):
        for j in range(l-i-1):
            if array[j] > array[j+1]:
                swap(array, j, j+1)



def sortDescending(array):
    l = len(array)
    for i in range(l-1):
        for j in range(l-i-1):
            if array[j] < array[j+1]:
                swap(array, j, j+1)


def swap(array, index1, index2):
    temp = array[index1]
    array[index1] = array[index2]
    array[index2] = temp


def display(array):
    l = len(array)
    for x in range(l):
        print(array[x])





array = [-2, 45, -12, 11, -9 ]
sortDescending(array)

display(array)