from django.shortcuts import render, redirect, HttpResponse
from django.utils.crypto import get_random_string

def index(request):

    request.session['count'] = request.session['count'] + 1


    getword = {
        'word' : get_random_string(length=14),
    }
    return render(request, 'word_generator/index.html', getword)

def reset(request):
    request.session.clear()

    return redirect('/random_word')



