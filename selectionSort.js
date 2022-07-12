function selectionSort(arr){

    let len = arr.length;
    for (i = 0; i < len; i++){
    let minIndex = i;
        for (j = i+1; j < len; j++){
            if (arr[j] < arr[minIndex]) {
                minIndex = j; 
            }
        }
        //swap
        let temp = arr[minIndex];
        arr[minIndex] = arr[i];
        arr[i] = temp;
    }    
    
    display(arr);
}

function display(arr) {
    let len = arr.length;

    for (i = 0; i < len; i++){
        console.log(arr[i]);
    }
}

let arr = [64,25,12,22,11];
selectionSort(arr);