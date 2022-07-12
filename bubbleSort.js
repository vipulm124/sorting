function bubbleSort(arr) {
    
    let len = arr.length;

    for (i = 0; i < len - 1; i++){
        for (j = 0; j < len - 1; j++){
            if (arr[j] > arr[j + 1]) {
                let temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;

            }
        }
    }
    display(arr);
}

function display(arr) {
    let len = arr.length;

    for (i = 0; i < len; i++){
        console.log(arr[i]);
    }
}   

let arr = [-2, 45,-12, 11, -9];
bubbleSort(arr);