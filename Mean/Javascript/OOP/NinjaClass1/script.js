
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

}
var MyNinja = new Ninja("Michael");
MyNinja.sayName();
MyNinja.showStats();
MyNinja.drinkShake();
MyNinja.showStats();