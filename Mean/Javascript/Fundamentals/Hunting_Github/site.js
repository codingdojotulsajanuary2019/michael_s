
$(document).ready(function(){
    $('#button').click(function(){
        $.get("https://api.github.com/users/MichaelJShea", displayName);
        // Notice that displayName is a function that takes in 1 parameter (this is the data that comes back from the API)
        function displayName(data) {
          console.log(data.name);
          $(document.getElementById('name').append(`${data.name}`));
        }
    });
});
