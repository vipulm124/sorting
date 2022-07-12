function pivotIndex(arr, left, right) {
    
    //pick first element as pivot
    //get the expected index of the pivot


    let count = 0;
    let pivotElem = arr[left];

    for (let i = left + 1; i <= right; i++){
        if (arr[i] < pivotElem) {
            count++;
        }
    }

    let pivotIndex = left + count;
    
    swap(arr, left, pivotIndex);

    let i = left;
    let j = right;

    while (i < pivotIndex && j > pivotIndex) {
        while (arr[i] < pivotElem) {
            i++;
        }
        while (arr[j] > pivotElem) {
            j++;
        }

        if (i < pivotIndex && j > pivotIndex) {
            swap(arr, i, j);
        }
    }
    return pivotIndex;
}

function swap(arr, idx1, idx2) {
    let temp = arr[idx1];
    arr[idx1] = arr[idx2];
    arr[idx2] = temp;
}


function quickSort(arr, left, right) {
    
    if(left >= right){
        return;
    }
    let pivotIdx = pivotIndex(arr, left, right);

    quickSort(arr, left, pivotIdx - 1);
    quickSort(arr, pivotIdx + 1, right);
}

function display(arr) {
    for (i = 0; i < arr.length; i++){
        console.log(arr[i]);
    }
}


let arr = [-2, 45, 0, 11, -9];
quickSort(arr, 0, arr.length - 1);
display(arr);
