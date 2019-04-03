function Foo()
{
    const privatemethod = () => console.log(this);
    this.greet = function(){
        console.log("hello");
        privatemethod();
    };
}
const joe = new Foo();
joe.greet();