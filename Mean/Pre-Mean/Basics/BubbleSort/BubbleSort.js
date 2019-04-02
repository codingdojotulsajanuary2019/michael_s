
function BubbleSort(arr)
{
    for(var i = 0; i < arr.length; i++)
    {
        for(var x = i+1; x < arr.length; x++)
        {
            if(arr[x] < arr[i])
            {
                temp = arr[i];
                arr[i] = arr[x];
                arr[x] = temp;
                console.log(arr);
            }
        }
    }
    console.log(arr);
}

var Sort = [3,6,9,2,5,7,1];
BubbleSort(Sort);