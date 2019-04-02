

function MakeChange(num)
{
    var count = num;
    var Change =
    {
        "Dollars" : 0,
        "Quarters" : 0,
        "Dimes" : 0,
        "Nickles" : 0,
        "Pennies" : 0, 
    };

    if(count >= 100)
    {
        var dollars = Math.floor(count/100);
        Change.Dollars += dollars;
        count -= dollars * 100; 
    }
    if(count >= 25)
    {
        var quarters = Math.floor(count/25);
        Change.Quarters += quarters;
        count -= quarters * 25;
    }
    if( count >= 10)
    {
        var dimes = Math.floor(count/10);
        Change.Dimes += dimes;
        count -= dimes * 10;
    }
    if( count >= 5)
    {
        var nickels = Math.floor(count/5);
        Change.Nickles += nickels;
        count -= nickles;
    }
    if ( count < 5)
    {
        var pennies = count;
        Change.Pennies += count;
        count-= pennies;
    }

    console.log(Change);

}

MakeChange(226);