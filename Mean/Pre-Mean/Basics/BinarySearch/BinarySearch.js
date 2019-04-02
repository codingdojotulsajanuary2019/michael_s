

function BinarySearch(arr, num)
{
    var mid = Math.floor(arr.length/2);
    var start = arr[0];
    var end = arr.length-1;
    console.log(arr[mid]);

    while(num < arr[mid])
    {
        end = mid-1;
        mid = arr[(start + end)/2];
        console.log(mid);
    }

    while(num > arr[mid])
    {
        start = mid +1;
        mid  = arr[(start +end)/2];
        console.log(mid);
    }
}

BinarySearch([1, 3, 8, 10, 12, 15, 17, 20, 22, 34, 38, 40, 50, 52, 78, 87, 90, 91, 92, 94], 15);