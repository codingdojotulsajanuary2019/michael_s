from django.shortcuts import render, HttpResponse

def index(request):

    return HttpResponse("this is the equivilent of @app.route('/')!")

# Create your views here.
