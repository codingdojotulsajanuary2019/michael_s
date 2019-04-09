module.exports = function(){
    var _ = {
        map: function() {
          //code here;
        },
        reduce: function() { 
          // code here;
        },
        find: function() {   
          // code here;
        },
        filter: function(arr, callback) { 
          // code here;
          for( var i = 0; i < arr.length; i++)
          {
              if(arr[i] % 2 === 0 )
              {
                  callback(arr[i]);
              }
          }
        },
        reject: function() { 
          // code here;
        }
      }
}