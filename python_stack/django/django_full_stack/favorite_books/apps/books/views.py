from django.shortcuts import render, redirect
from apps.login_register.models import User


def show_books(request):

    return render(request, 'books/addbook.html')
