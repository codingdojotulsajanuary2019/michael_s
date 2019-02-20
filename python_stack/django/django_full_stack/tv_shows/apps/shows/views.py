from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages

# SHOW TABLE OF ALL SHOWS
def allshows(request):
    all_shows = Shows.objects.all()
    print(all_shows)
    context = {
        "all_shows": all_shows
    }

    return render(request, 'shows/allshows.html', context)

# SHOW ADD SHOW FORM
def show_add_show(request):

    return render(request, 'shows/addshow.html')

# ADD A NEW SHOW
def add_new_show(request):
    errors = Shows.objects.show_vaildator(request.POST)
    print(errors)
    if len(errors) > 0:
        for tag, message in errors.items():
            messages.error(request, message, extra_tags = tag)
        return redirect('/shows/new')
    else:

        Shows.objects.create(title = request.POST['showtitle'], network = request.POST['shownetwork'], release_date = request.POST['releasedate'], description = request.POST['showdescription'])

        return redirect('/')

#SHOW TO SPECIFIC SHOW BY ID
def show_show(request, id):
    show_id = int(id)
    show = Shows.objects.get(id = show_id)
    context = {'show': show}

    return render(request, 'shows/viewshow.html', context)

#SHOW THE SHOW USER WANTS TO EDIT
def show_edit_show(request, id):
    show_id = int(id)
    show = Shows.objects.get(id = show_id)
    context = {'show': show}
    print(show.release_date)

    return render(request, 'shows/editshow.html', context)

#ROUTE TO UPDATE SHOW INFO
def update_show(request, id):
    show_id = int(id)
    errors = Shows.objects.show_vaildator(request.POST)
    print(errors)
    if len(errors) > 0:
        for tag, message in errors.items():
            messages.error(request, message, extra_tags = tag)
        return redirect(f'/shows/{show_id}/edit')
    else:
        show_id = int(id)
        update_show = Shows.objects.get(id=show_id)
        update_show.title = request.POST['showtitle']
        update_show.network = request.POST['shownetwork']
        update_show.release_date = request.POST['releasedate']
        update_show.description = request.POST['showdescription']
        update_show.save()

    return redirect ('/')

#DELETE A SHOW
def delete_show(request, id):
    show_id = int(id)
    delete_show = Shows.objects.get(id=show_id)
    delete_show.delete()

    return redirect('/')





