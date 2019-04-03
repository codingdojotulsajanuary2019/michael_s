class Card
{
    constructor(suit, name, value)
    {
        this.suit = suit;
        this.name = name;
        this.value = value;
    }
    showCard()
    {
        console.log(`${this.name} of ${this.suit}`);
    }
}

class Deck
{
    constructor()
    {
        this.reset();
    }
    reset()
    {
            const h1 = new Card('Hearts', 'Ace', 1);
            const h2 = new Card('Hearts', 'Two', 2);
            const h3 = new Card('Hearts', 'Three', 3);
            const h4 = new Card('Hearts', 'Four', 4);
            const h5 = new Card('Hearts', 'Five', 5);
            const h6 = new Card('Hearts', 'Six', 6);
            const h7 = new Card('Hearts', 'Seven', 7);
            const h8 = new Card('Hearts', 'Eight', 8);
            const h9 = new Card('Hearts', 'Nine', 9);
            const h10 = new Card('Hearts', 'Ten', 10);
            const h11 = new Card('Hearts', 'Jack', 11);
            const h12 = new Card('Hearts', 'Queen', 12);
            const h13 = new Card('Hearts', 'King', 13);
            const d1 = new Card('Diamonds', 'Ace', 14);
            const d2 = new Card('Diamonds', 'Two', 15);
            const d3 = new Card('Diamonds', 'Three', 16);
            const d4 = new Card('Diamonds', 'Four', 17);
            const d5 = new Card('Diamonds', 'Five', 18);
            const d6 = new Card('Diamonds', 'Six', 19);
            const d7 = new Card('Diamonds', 'Seven', 20);
            const d8 = new Card('Diamonds', 'Eight', 21);
            const d9 = new Card('Diamonds', 'Nine', 22);
            const d10 = new Card('Diamonds', 'Ten', 23);
            const d11 = new Card('Diamonds', 'Jack', 24);
            const d12 = new Card('Diamonds', 'Queen', 25);
            const d13 = new Card('Diamonds', 'King', 26);
            const s1 = new Card('Spades', 'Ace', 27);
            const s2 = new Card('Spades', 'Two', 28);
            const s3 = new Card('Spades', 'Three', 29);
            const s4 = new Card('Spades', 'Four', 30);
            const s5 = new Card('Spades', 'Five', 31);
            const s6 = new Card('Spades', 'Six', 32);
            const s7 = new Card('Spades', 'Seven', 33);
            const s8 = new Card('Spades', 'Eight', 34);
            const s9 = new Card('Spades', 'Nine', 35);
            const s10 = new Card('Spades', 'Ten', 36);
            const s11 = new Card('Spades', 'Jack', 37);
            const s12 = new Card('Spades', 'Queen', 38);
            const s13 = new Card('Spades', 'King', 39);
            const c1 = new Card('Clubs', 'Ace', 40);
            const c2 = new Card('Clubs', 'Two', 41);
            const c3 = new Card('Clubs', 'Three', 42);
            const c4 = new Card('Clubs', 'Four', 43);
            const c5 = new Card('Clubs', 'Five', 44);
            const c6 = new Card('Clubs', 'Six', 45);
            const c7 = new Card('Clubs', 'Seven', 46);
            const c8 = new Card('Clubs', 'Eight', 47);
            const c9 = new Card('Clubs', 'Nine', 48);
            const c10 = new Card('Clubs', 'Ten', 49);
            const c11 = new Card('Clubs', 'Jack', 50);
            const c12 = new Card('Clubs', 'Queen', 51);
            const c13 = new Card('Clubs', 'King', 52);

        this.deck = [h1,h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12, h13, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13];
        this.shuffle();
    }

    shuffle()
    {
        var m = this.deck.length;
        var t;
        var i;

        while(m)
        {
            i = Math.floor(Math.random()* m --);
            t = this.deck[m];
            this.deck[m] = this.deck[i];
            this.deck[i] = t;
        }
        return this.deck;
    }

    deal()
    {
        console.log(`You have been delt the ${this.deck[this.deck.length-1].name} of ${this.deck[this.deck.length-1].suit} `);
        return this.deck.pop();

    }


}

class Player
{
    constructor(name)
    {
        this.name = name;
        this.hand = [];

    }

    takeCard(Deck)
    {
        var card = Deck.deal();
        this.hand.push(card);
    }

    viewHand()
    {
        console.log(this.hand);
    }

    discard()
    {
        this.hand.pop();
        viewHand();
    }
}

const MyDeck = new Deck();
const Player1 = new Player;
Player1.takeCard(MyDeck)
Player1.takeCard(MyDeck)
Player1.viewHand();
Player1.discard();

