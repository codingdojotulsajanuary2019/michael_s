from django.shortcuts import render, redirect
from .models import User, UserManager
from django.contrib import messages
import bcrypt

def show_login(request):

    return render(request, 'login_register/login.html')

def login(request):
    errors = User.objects.login_validator(request.POST)

    if errors != None:
        for tag, message in errors.items():
            messages.error(request, message, extra_tags = tag)
            
        return redirect('/')
    if errors == None:
        user = User.objects.get(email = request.POST['login_email'])
        request.session['first_name'] = user.first_name

        return redirect('/success')

def show_registration(request):

    return render(request, 'login_register/register.html')

def register_user(request):
    errors = User.objects.registration_validator(request.POST)
    print(errors)
    if errors != None:
        for tag, message in errors.items():
            messages.error(request, message, extra_tags = tag)
            
        return redirect('/signup')

    if errors == None:
        new_user = User.objects.filter(email = request.POST['email'])
        request.session['user_id'] = new_user.id
        request.session['first_name'] = new_user.first_name

        return redirect('/success')

def success(request):

    return render(request, 'login_register/success.html')
