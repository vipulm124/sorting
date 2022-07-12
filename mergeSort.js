function divide(arr, left, right) {
    // console.log('hi');
    if (left >= right) {
        return;
    }

    let mid = parseInt(left + (right - left) / 2);
    
    divide(arr, left, mid);
    divide(arr, mid + 1, right);
    conquer(arr, left, mid, right);
    
}

function conquer(arr, left, mid, right) {
    // console.log(right);
    // console.log(left);
    let merged = new Array(right-left+1);

    let idx1 = left;
    let idx2 = mid + 1;
    let idx3 = 0;

    while (idx1 <= mid && idx2 <= right) {
        if (arr[idx1] <= arr[idx2]) {
            merged[idx3] = arr[idx1];
            idx1++
        }
        else {
            merged[idx3] = arr[idx2];
            idx2++
        }
        idx3++;
    }

    while (idx1 <= mid) {
        merged[idx3] = arr[idx1];
        idx1++;
        idx3++;
    }

    while (idx2 <= right) {
        merged[idx3] = arr[idx2];
        idx2++;
        idx3++;
    }
    
    for (i = 0; i < merged.length; i++){
        arr[left + i] = merged[i];
    }

}

function display(arr) {
    for (i = 0; i < arr.length; i++){
        console.log(arr[i]);
    }
}


let arr = [-2, 45, -12, 11, -9];
divide(arr, 0, arr.length - 1);
display(arr);