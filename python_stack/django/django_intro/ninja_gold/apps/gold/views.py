from django.shortcuts import render, redirect
import random


def index(request):
    if 'gold_count' not in request.session:
        request.session['gold_count'] = 0
    else:
        request.session['gold_count'] = request.session['gold_count']

    if 'message' not in request.session:
        request.session['message'] = "<li> Welcome to Ninja Gold </li>"

    return render(request, 'gold/index.html')

def process_money(request):
    print("*"*80)
    if request.method == "POST":
        if request.POST['gold'] == 'farm':
            num = random.randint(9,20)
            request.session['gold_count'] += num
            request.session['message'] = f"<li>You found {num} gold at the farm </li>" + request.session['message']
            return redirect('/')
        if request.POST['gold'] == 'cave':
            num = random.randint(4, 10)
            request.session['gold_count'] += num
            request.session['message'] = f"<li>You found {num} gold in the cave </li>" + request.session['message']
            return redirect('/')
        if request.POST['gold'] == 'house':
            num = random.randint(1, 5)
            request.session['gold_count'] += num
            request.session['message'] = f"<li>You found {num} gold in the House </li>" + request.session['message']

            return redirect('/')
        if request.POST['gold'] == 'casino':
            num = random.randint(-51, 50)
            request.session['gold_count'] += num
            request.session['message'] = f"<li>You found {num} gold at the casino </li>" + request.session['message']
            
            return redirect('/')

    return redirect('/')

def reset(request):
    request.session.clear()

    return redirect('/')
