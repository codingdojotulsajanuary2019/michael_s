
function Ninja(name)
{
    this.name = name;
    this.health = 100;
    var speed = 3;
    var strength = 3;

    this.sayName = function()
    {
        console.log(`My Ninja Name is ${this.name}`);
    };

    this.showStats = function()
    {
        console.log (`Name: ${this.name}, Health: ${this.health}, Speed: ${speed}, Strength: ${strength}`);
    };

    this.drinkShake = function()
    {
        this.health += 10;
        return this;
    };

    this.punch = function(target)
    {
        target.health -= 5;
        console.log(`${target.name} was punched by ${this.name} and lost 5 health`);
    };

    this.kick = function(target)
    {
        var amount = strength * 15;
        console.log(amount);
        target.health -= amount;
        console.log(`In this case ${target.name} lost ${amount} health because ${this.name} has ${strength} of strength`);
    }



}
var Ninja1 = new Ninja("Michael");
var Ninja2 = new Ninja("Pat MaGroin");
Ninja2.showStats();
Ninja1.punch(Ninja2);
Ninja2.showStats();
Ninja2.kick(Ninja1);
Ninja1.showStats();

