$(document).ready(function(){
    alert("jQuery is working!")

    $('img').hover(
        function()
            {
                $(this).attr('src', 'tenor.gif');
            },
        function()
            {
                $(this).attr('src', 'dog.jpg');
            });

});