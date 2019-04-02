var Heffalumps = {
    name: "Heffalumps",
    greet: function()
    {
        console.log("Hi I am Heffalumps");
    }
};
var Eeyore = {
    name: "Eeyore",
    greet: function()
    {
        console.log("Hi I'm Eeyore");
    }
};
var Kanga = {
    name: "Kanga",
    greet: function()
    {
        console.log("Hi I'm Kanga");
    }
};
var Owl = {
    name: "Owl",
    greet: function()
    {
        console.log("Hoot Hoot Hoot");
    }
};
var Christopher = {
    name: "Christopher Robin",
    greet: function()
    {
        console.log("Hi I'm Christopher Robin!");
    }
};
var Rabbit = {
    name: "Rabbit",
    greet: function()
    {
        console.log("Hi I am Rabbit!");
    }
}; 
var Gopher = {
    name: "Gopher",
    greet: function()
    {
        console.log("Hi I am Gopher!");
    }
};
var Piglet = {
    name: "Piglet",
    greet: function()
    {
        console.log("oh d-d-d-d-dear! I  wasn't expecting company!");
    }
};
var Pooh = {
    name: "Winnie The Pooh",
    greet: function()
    {
        console.log("Oh bother");
    }
};
var Bees = {
    name: "Bees",
    greet: function()
    {
        console.log("Buzzzz Buzzzz");
    }
};
var Tiger = {
    name: "Tiger",
    greet: function()
    {
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!");
    }
};

Heffalumps.West = Eeyore;
Eeyore.East = Heffalumps;
Eeyore.South = Kanga;
Kanga.North = Eeyore;
Kanga.South = Christopher;
Christopher.North = Kanga;
Christopher.West = Owl;
Christopher.East = Rabbit;
Christopher.South = Pooh;
Owl.East = Christopher;
Owl.South = Piglet;
Rabbit.West = Christopher;
Rabbit.South = Bees;
Rabbit.East = Gopher;
Gopher.West = Rabbit;
Piglet.North = Owl;
Piglet.East = Pooh;
Pooh.West = Piglet;
Pooh.North = Christopher;
Pooh.East = Bees;
Pooh.South = Tiger;
Bees.North = Rabbit;
Bees.West = Pooh;
Tiger.North = Pooh;


var player = {
    location: Tiger,
    honey: false,
    mission: Pooh,
};

function Mission(){
    var val = Math.floor(Math.random()*11)+1;
    if (val === 1) {player.mission = Heffalumps}
    if (val === 2) {player.mission = Eeyore}
    if (val === 3) {player.mission = Kanga}
    if (val === 4) {player.mission = Owl}
    if (val === 5) {player.mission = Christopher}
    if (val === 6) {player.mission = Rabbit}
    if (val === 7) {player.mission = Gopher}
    if (val === 8) {player.mission = Pooh}
    if (val === 9) {player.mission = Tiger}
    if (val === 10) {player.mission = Piglet}

}
Mission();

console.log(`Welcome To Honey Delivery!, you are starting at ${player.location.name}'s house`);
console.log(`You must pick up the honey from the bees and carry it to ${player.mission.name}'s house to win!`);
