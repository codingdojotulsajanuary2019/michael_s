class Bike
{
    constructor(public price: number, public max_speed: string, public miles: number = 0, ) { }

    displayInfo = () => {
        console.log(`Price:${this.price}, Max Speed: ${this.max_speed}, Miles: ${this.miles}`);
    }

    ride = () => {
        console.log("RIDING");
        this.miles += 10;
        return this;
    }

    reverse = () => {
        console.log("REVERSING");
        if (this.miles > 0) {
            this.miles -= 5;
        }
        return this;
    }
}

const Bike1 = new Bike(1000, "20mph");
const Bike2 = new Bike(2000, "25mph");
const Bike3 = new Bike(3000, "30mph");


Bike1.ride().ride().ride().reverse().displayInfo()


Bike2.ride().ride().reverse().reverse().displayInfo()


Bike3.reverse().reverse().reverse().reverse().displayInfo()



