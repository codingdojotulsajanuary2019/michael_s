from django.shortcuts import render
from time import gmtime, strftime

def index(request):
    context = {
        "time": strftime("%c", gmtime())
    }
    print(context)

    return render(request, "show_time/index.html", context)

# Create your views here.
