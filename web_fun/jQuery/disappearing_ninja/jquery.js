$(document).ready(function(){
    alert("jQuery is running!")

    $('.container img').click(function(){
        $(this).hide();
        console.log($(this));
    });

    $('.reset button').click(function(){
        location.reload();
    });
});