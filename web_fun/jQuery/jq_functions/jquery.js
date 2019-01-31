
$('document').ready(function(){
    alert("jQuery Started");

    $('.show').hide();
    $('hide').show();

    $('button.togglebtn').click(function()
    {
        console.log("BUTTON CLICKED")
        $('.hide').toggle();

    });

    $('button.before').click(function()
    {
        $('p.add').before("<p>THIS IS A NEW PARAGRAPH</p>")
    });

    $("button.html").click(function()
    {
        $("p").html("This was changed by the HTML Button")
    })

    $("button.showbtn").click(function()
    {
        $('.show').show()
    });

    $('button.hidebtn').click(function()
    {
        $('.hide').hide()
    });
});


