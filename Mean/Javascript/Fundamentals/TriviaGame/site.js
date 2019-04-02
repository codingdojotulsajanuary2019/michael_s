$(document).ready(function(){
    var score = 0;
    var questions;
    var questionnum = 0;
    $('#score').html(`<h5 class='grey-text text-lighten-5'>SCORE: ${score} points </h5>`);
    $.get('https://opentdb.com/api.php?amount=10&category=21&difficulty=medium&type=multiple', DisplayGame);
    function DisplayGame(data)
    {
        
        questions = data.results;
        console.log(questions);
        DisplayQuestion(0);
    }
    function DisplayQuestion(num)
    {
        $('#question').html(`                    
            <div class="card blue-grey darken-1">
            <div class="card-content white-text">
            <h5 class="grey-text text-lighten-5">Question #${questionnum + 1}:</h5>
            <p>${questions[num].question}</p>
            </div>
                <div class="card-action center-align">
                    <p>
                        <button id="answer" class="btn waves-effect waves-light" type="button" value="${questions[num].incorrect_answers[1]}">
                        ${questions[num].incorrect_answers[0]}
                        <i class="material-icons right">send</i>
                        </button>
                        </p>
                    <p>
                        <button id="answer" class="btn waves-effect waves-light" type="button" value="${questions[num].incorrect_answers[0]}">
                        ${questions[num].incorrect_answers[1]}
                        <i class="material-icons right">send</i>
                        </button>
                    </p>
                    <p>
                        <button id="answer" class="btn waves-effect waves-light" type="button" value="${questions[num].correct_answer}">
                        ${questions[num].correct_answer}
                        <i class="material-icons right">send</i>
                        </button>
                    </p>
                    <p>
                        <button id="answer" class="btn waves-effect waves-light" type="button" value="${questions[num].incorrect_answers[2]}">
                        ${questions[num].incorrect_answers[2]}
                        <i class="material-icons right">send</i>
                        </button>
                    </p>
                </div>
            </div>`
            
            );

        }
            $(document).on('click','#answer',function(){
                if($(this).val() === questions[questionnum].correct_answer)
                {
                    console.log("CORRECT!!")
                    score = score +25;
                    $('#score').html(`<h5 class='grey-text text-lighten-5'>SCORE: ${score} points </h5>`);
                    questionnum = questionnum +1;
                    console.log(`Now Question # ${questionnum}`);
                    DisplayQuestion(questionnum);
                }
                else
                {
                    M.toast({html: 'Wrong! So Sorry!'})
                    questionnum = questionnum +1;
                    console.log(`Now Question # ${questionnum}`);
                    DisplayQuestion(questionnum);
                }
    
            });

});

