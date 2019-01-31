// function sigma(n)
//     {
//         var sum = 0;

//         for(var i = 0; i <= n; i++)
//             {
//                 sum = sum + i; 
//             }
//         return sum;
//     }

// console.log(sigma(3));


// function factorial(num)
//     {
//         var sum = 1;

//         for(var i =1; i <= num; i++)
//             {
//                 sum =  sum * i;
//             }
//         return sum;
//     }

// console.log(factorial(5));


// function fibonacci(num)
//     {
//         var a = 1;
//         var b = 0,
//         temp = 0;

//         for(var i = 1; i <= num; i++)
//             {
//                 temp = a;
//                 a = a + b;
//                 b = temp;
//             }
//         return b;
//     }
// console.log(fibonacci(6));

// function secToLast(arr)
//     {
//         if(arr.length < 2)
//             {
//                 return null;
//             }
//         return arr[arr.length-2];
//     }

// console.log(secToLast(["Michael", 25, "Shea", 25]));


// function nthToLast(arr,x)
//     {
//         if(arr.length < x)
//             {
//                 return null;
//             }

//         return arr[arr.length-x]
//     }

// console.log(nthToLast([1,2,3,4,5], 3));


// function secondLargest(arr)
//     {
//         var high = 0;
//         var secondhigh = 0;

//         for(var i = 0; i < arr.length; i++)
//             {
//                 if(arr.length < 2)
//                     {
//                         return null;
//                     }
//                 if(arr[i] > high)
//                     {
//                         var high = arr[i];
//                     }
//                 if(arr[i] > secondhigh && arr[i] < high)
//                     {
//                         var secondhigh = arr[i]
//                     }
//             }
//         return secondhigh;
//     }

// console.log(secondLargest([42,1,4,3.14,41]));


// function dubTrub(arr)
//     {
//         newArr = []

//         for(var i = 0; i < arr.length; i++)
//             {
//                 newArr.push(arr[i]);
//                 newArr.push(arr[i]);
//             }
//         return newArr;
//     }

// console.log(dubTrub([1,"Michael", false]));

function fibonacci(num) {
    if (num <= 1) return 1;

    return fibonacci(num - 1) + fibonacci(num - 2);
}

console.log(fibonacci(10));






