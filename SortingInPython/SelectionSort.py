
def sortAscending(array):
    l = len(array)
    minIndex = -1
    for i in range(l):
        minIndex = i
        for j in range(i+1, l):
            if array[j] < array[minIndex]:
                minIndex = j
        
        swap(array, i, minIndex)



def sortDescending(array):
    l = len(array)
    minIndex = -1
    for i in range(l):
        minIndex = i
        for j in range(i+1, l):
            if array[j] > array[minIndex]:
                minIndex = j
        
        swap(array, i, minIndex)




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