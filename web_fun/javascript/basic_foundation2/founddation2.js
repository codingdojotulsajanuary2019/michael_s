// function makeItBig(arr){
//     for (var i = 0; i < arr.length; i++)
//         {
//             if(arr[i] > 0)
//                 {
//                     arr[i] = "BIG";
//                 }
//         }
//     return arr;
// }

// console.log(makeItBig([-1,3,5,-5]));


// function printLowReturnHigh(arr)
//     {
//         var low = arr[0];
//         var high = arr[0];

//         for(var i = 0; i < arr.length; i++)
//             {
//                 if(arr[i] < low)
//                     {
//                         low = arr[i];
//                     }
//                 if(arr[i] > high)
//                     {
//                         high = arr[i];
//                     }
//             }
//         console.log(low);
//         return high;
//     }

// printLowReturnHigh([1,2,3,4,5,6,7,8,9]);


// function printOneReturnAnother(arr)
//     {
//         console.log(arr[arr.length-2])

//         for (var i = 0; i < arr.length; i++) {
//             if (arr[i] % 2 !== 0)
//                 {
//                     return arr[i];
//                 }
//         }
//     }

// console.log(printOneReturnAnother([2,4,6,5,10,12,14]));


// function doubleVision(arr)
//     {
//         var newArr = [];

//         for(var i = 0; i < arr.length; i++)
//             {
//                 newArr.push(arr[i]*2)
//             }
//         return newArr;
//     }

// console.log(doubleVision([1,2,3,4,5,]));


// function countPositives(arr)
//     {
//         var count = 0;

//         for(var i = 0; i < arr.length; i++)
//             {
//                 if(arr[i] > 0)
//                     {
//                         count += 1;
//                     }
//             }
//         arr[arr.length-1] = count;

//         return arr;
//     }

// console.log(countPositives([1,1,-2,2,-3]));


// function evensAndOdds(arr)
//     {
//         for(var i = 1; i < arr.length; i++)
//             {
//                 if(arr[i] % 2 !== 0 && arr[i-1] % 2 !== 0 && arr[i+1] % 2 !== 0)
//                     {
//                         console.log("That's Odd!")
//                     }
//                 if (arr[i] % 2 === 0 && arr[i - 1] % 2 === 0 && arr[i + 1] % 2 === 0)
//                     {
//                         console.log("Even More So!")
//                     }
//             }
//     }

// evensAndOdds([1,1,1,2,2,2,1,2,3]);



// function incrementTheSeconds(arr)
//     {
//         for(var i = 0; i < arr.length; i++)
//             {
//                 if(i % 2 !== 0)
//                     {
//                         arr[i] = arr[i] + 1;
//                         console.log(arr[i]);
//                     }
//             }
//         return arr;
//     }

// incrementTheSeconds([1,2,3,4,5,6,7,8,9]);



// function previousLengths(arr)
//     {
//         for(var i = arr.length - 2; i > -1; i--)
//             {
//                 arr[i + 1] = arr[i].length;
//             }
//         return arr;
//     }

// previousLengths(["Hello","Dojo","Awesome", "Michael"]);


// function sevenToMost(arr)
//     {
//         var newArr = [];

//         for(var i = 0; i < arr.length; i++)
//             {
//                 newArr.push(arr[i]+7);
//             }
//         return newArr;
//     }

// sevenToMost([1,2,3,4,5,6]);


// function reverse(arr)
//     {
//         for(var i = 0; i < arr.length/2; i++)
//             {
//                 var temp = arr[i];
//                 arr[i] = arr[arr.length-(i+1)];
//                 arr[arr.length-(i+1)] = temp;
//             }
//         return arr;
//     }

// reverse([1,2,3,4,5,6,7,8,9]);


// function outlookNeg(arr)
//     {
//         var newArr = [];

//         for(var i = 0; i < arr.length; i++)
//             {
//                 if(arr[i] > 0)
//                     {
//                         newArr.push(arr[i] * -1);
//                     }
//                 else 
//                     {
//                         newArr.push(arr[i]);
//                     }
//             }
//         return newArr;
//     }

// console.log(outlookNeg([1,-2,3,-4,5]));



// function alwaysHungry(arr)
//     {
//         for(var i = 0; i < arr.length; i++)
//             {
//                 if (arr[i] === "food")
//                     {
//                         console.log("YUMMY");
//                     }
//                 if (arr[i] !== "food" && arr[arr.length - 1] !== "food")
//                     {
//                         console.log("I'm Hungry")
//                         break;
//                     }
                
                
//             }
//     }

// alwaysHungry(["food",1,1,2,"food"]);



// function swapToCenter(arr)
//     {

//             var temp = 0;
//             var low = 0;
//             var high = arr.length - 1;
//             var middle = arr.length / 2; // arg[3] which is 4

//             temp = arr[0];
//             arr[0] = arr[high];
//             arr[high] = temp;

//             temp = arr[middle];
//             arr[middle] = arr[middle - 1];
//             arr[middle - 1] = temp;

//             return(arr);
//     }
// swapToCenter([1,2,3,4,5,6]);


function numToString(arr)
    {
        for(var i = 0; i < arr.length; i++)
            {
                if(arr[i] < 0)
                    {
                        arr[i] = "Dojo"
                    }
            }
        return arr;
    }

numToString([-1,-3,2]);



