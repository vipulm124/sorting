function insertionSort(arr) {
    
    let len = arr.length;

    for (i = 1; i < len; i++){
        let temp = arr[i];
        let j = i - 1;
        while (j >= 0) {
            if (arr[j] > temp) {
                arr[j + 1] = arr[j];
            }
            else {
                break;
            }
            j--;
        }
        arr[j + 1] = temp;
    }
}


function display(arr) {
    let len = arr.length;

    for (i = 0; i < len; i++){
        console.log(arr[i]);
    }
}



let arr = [-2, 45, 0, 11, -9];
insertionSort(arr);
display(arr);
