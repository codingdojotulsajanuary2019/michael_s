module.exports = function (){
    return {
      add: function(num1, num2) { 
           // add code here 
           return num1 + num2;
      },
      multiply: function(num1, num2) {
           // add code here 
           return num1 * num2;
      },
      square: function(num) {
           // add code here 
           return num**2;
      },
      random: function(num1, num2) {
           // add code here
           return Math.floor(Math.random() * Math.abs(num1-num2)+Math.min(num1, num2));
      }
    }
  };
  