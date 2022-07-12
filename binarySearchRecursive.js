function binarySearch(arr, left, right, val) {
    if (left > right) {
        return -1;
    }
    let mid = parseInt(left + (right-left) / 2);
    // console.log(mid);
    // console.log(arr[mid]);

//value is in left section    
    if (val < arr[mid]) {
        return binarySearch(arr, left, mid - 1, val);
    }
    // value is in right section
    else if (val > arr[mid]) {
       return  binarySearch(arr, mid + 1, right, val);
    }
    else {
        return mid;
    }
    return -1;
}



let arr = [-12,-9,-2,11,45];
let index = binarySearch(arr, 0, arr.length - 1, 118);
console.log(index);