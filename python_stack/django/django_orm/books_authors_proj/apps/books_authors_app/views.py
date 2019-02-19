from django.shortcuts import render, redirect
from .models import Book, Author


def index(request):

    context = {
        "books_table" : Book.objects.all()
    }
    
    return render(request, 'books_authors_app/addbook.html', context)

def add_book(request):
    if request.method == 'POST':

        Book.objects.create(title = request.POST['title'], description = request.POST['description'])

    return redirect("/")

def delete_book(request, id):
        book_id = int(id)

        delete_book = Book.objects.get(id= book_id )
        delete_book.delete()

        return redirect ("/")

def view_book(request, id):
    book_id = int(id)

    view_book = Book.objects.get(id=book_id)
    not_author = Author.objects.exclude(books = book_id)
    

    context = {
        'book': view_book,
        'not_author' : not_author,
    }
    print("$"*80)
    print(not_author)

    return render(request, 'books_authors_app/view_book.html', context)

def add_author_to_book(request, id):
    book_id = int(id)

    book = Book.objects.get(id = book_id)
    request = request.POST['add_author']
    first_name, last_name = request.split(" ")
    author = Author.objects.get(first_name = first_name, last_name = last_name)

    book.authors.add(author)


    return redirect(f"/view_book/{book_id}")

def show_authors(request):
    authors = Author.objects.all()
    print("*"*80)
    print(authors)

    context = {
        'authors': authors
    }

    return render(request,'books_authors_app/addauthor.html', context)

def add_author(request):
    if request.method == 'POST':
        Author.objects.create(first_name = request.POST['auth_first_name'], last_name = request.POST['auth_last_name'], notes = request.POST['notes'])
        return redirect('/show_authors')

    return redirect('/show_authors')

def delete_author(request, id):
    auth_id = int(id)
    author = Author.objects.get(id=auth_id)
    author.delete()

    return redirect('/show_authors')

def view_author(request, id):
    auth_id = int(id)
    author = Author.objects.get(id=auth_id)
    not_book = Book.objects.exclude(authors=auth_id)

    context = {
        'author': author,
        'not_book': not_book,
    }

    return render(request, 'books_authors_app/view_author.html', context)

def add_book_to_author(request, id):
    if request.method == 'POST':
        auth_id = int(id)

        author = Author.objects.get(id=auth_id)
        book = Book.objects.get(title = request.POST['add_author'])

        author.books.add(book)
        print(author)
        

        return redirect(f"/view_author/{auth_id}")
    return redirect(f"/view_author/{auth_id}")
    



