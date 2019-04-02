

function FizzBuzz(num)
{
    for(var i = 0; i < num; i++)
    {
        
        if(i % 3 === 0 && i % 5 === 0)
        {
            console.log("FizzBuzz");
        }
        if(i % 3 === 0 && i % 5 !== 0)
        {
            console.log("Fizz");
        }
        if(i % 3 !== 0 && i % 5 === 0)
        {
            console.log("Buzz");
        }
        else
        {
            console.log(i);
        }
    }
}

FizzBuzz(15);