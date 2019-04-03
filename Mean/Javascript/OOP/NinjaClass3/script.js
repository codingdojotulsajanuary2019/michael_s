class Ninja
{
    constructor(name)
    {
        this.name = name;
        this.health = 100;
        this.speed = 3;
        this.strength = 3;
    }

    sayName()
    {
        console.log(`This Ninja'Name is: ${this.name}`);
    }
    showStats()
    {
        console.log(`Name: ${this.name}, Health: ${this.health}, Speed: ${this.speed}, Strength: ${this.strength}`);
    }
    drinkSake()
    {
        this.health += 10;
        console.log(`${this.name} drank some Sake and gained 10 Health`);
    }
}

class Sensei extends Ninja
{
    constructor(name)
    {   super(name);
        super.name = name;
        super.health = 200;
        super.speed = 10;
        super.strength = 10;
        this.wisdom = 10;
    }

    speakWisdom()
    {
        super.drinkSake();
        console.log("What one programmer can do in one month, two programmmers can do in two months");
        super.showStats();

    }

}

const MyNinja = new Ninja("Michael");
const MySensei = new Sensei("Jackie Chan");
MyNinja.showStats();
MySensei.speakWisdom();
