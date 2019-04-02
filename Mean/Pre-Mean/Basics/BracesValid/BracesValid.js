

function BracesValid(string)
{
    var isValid = true;
    var opens =
    {
        "(":0,
        "[":0,
        "{":0
    };
    var closes = 
    {
        ")": 0,
        "]":0,
        "}":0
    };

    for(var i = 0; i<string.length; i++)
    {
        if(string[i] === "(")
        {
            opens['('] ++;
        }
        if(string[i]===")")
        {
            closes[')'] ++;
        }
        if(string[i] === "[")
        {
            opens['['] ++;
        }
        if(string[i]==="]")
        {
            closes[']'] ++;
        }
        if(string[i] === "{")
        {
            opens['{'] ++;
        }
        if(string[i]==="{")
        {
            closes['{'] ++;
        }
        if(closes[')'] > opens['('])
        {
            isValid =  false;
        }
        if(closes[']'] > opens['['])
        {
            isValid = false;
        }
        if(closes['}'] > opens['{'])
        {
            isValid = false;
        }

    }
    console.log(isValid);
}

BracesValid("({[})");