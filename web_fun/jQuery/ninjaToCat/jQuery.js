$(document).ready(function()
{
    alert("jQuery is Working");

    $('img.ninja#0').click(function()
        {   
            $(this).attr('src', 'img/cat0.png');
        });
    $('img.ninja#1').click(function () 
        {
            $(this).attr('src', 'img/cat1.png');
        });
    $('img.ninja#2').click(function () 
        {
            $(this).attr('src', 'img/cat2.png');
        });
     $('img.ninja#3').click(function () 
        {
            $(this).attr('src', 'img/cat3.png');
        });
     $('img.ninja#4').click(function () 
        {
            $(this).attr('src', 'img/cat4.png');
        });
    
});