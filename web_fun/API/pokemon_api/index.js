$(document).ready(function(){
    // $.get()
    // $.post()
    for (var i=1 ;i<151; i++){
        $('#pokemon').append(`<img src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/shiny/${i}.png" value=${i}>`)
        }
    
        $('img').click(function(){
            id = $(this).attr('value')
            console.log(id)

            $.ajax({
                method: 'get',
                url: 'https://pokeapi.co/api/v2/pokemon/'+ id,
                // data: pokemon_index,
                dataType: 'json',
                success: function(res) {
                    // get the info form the request
                    console.log(res);
                    $('#info').html("<img src=https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/shiny/"+id+".png>")
                    $('#info').append("<h1> Name: "+ res.name + "</h1>")
                    $('#info').append("<h3> Types: </h3>") 
                        for(var x = 0; x < res.types.length; x++){
                            $('#info').append("<ul>" +"<li>" + res.types[x].type.name + "</li>" + "</ul>")
                    }
                    $('#info').append("<h3> Height: " + res.height + "</h3>")
                    $('#info').append("<h3> Weight: " + res.weight + "</h3>")
                },
                error: function(err) {
                    // server error
                },
                complete: function(next) {
                    // regardless of success or error, this will run
                    console.log('in done method');
                }
            })
        })
    console.log('after the ajax method');
})
