function binarySearch(arr, val) {
    
    let low = 0;
    let high = arr.length;
    

    while (low <= high) {
        let mid = parseInt(low + (high - low) / 2);
        //element is on left
        if (val < arr[mid]) {
            high = mid - 1;
        }

        //element is on right
        else if (val > arr[mid]) {
            low = mid + 1;
        }
        else {
        return mid;
        }
    }
    return -1;
}

let arr = [-12,-9,-2,11,45];
let index = binarySearch(arr, -92);
console.log(index);