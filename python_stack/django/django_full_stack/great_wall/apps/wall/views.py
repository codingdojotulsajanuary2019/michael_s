from django.shortcuts import render, redirect
from apps import login_register
from apps.login_register.models import User
from .models import Post
from .models import Comment
import datetime

def show_wall(request):
    if 'user_id' in request.session:
        posts = Post.objects.all()[:10]
        comments = Comment.objects.all()
        context = {
            'posts': posts,
            'comments' : comments
        }
        return render(request, 'wall/user_wall.html', context)
    else:
        return redirect('/')

def logout(request):
    request.session.clear()
    return redirect('/')

def make_post(request):
    user_id = User.objects.get(id = request.session['user_id'])
    Post.objects.create(message = request.POST['post'], user_id = user_id)

    return redirect('/user_wall')

def make_comment(request):
    user_id = User.objects.get(id = request.session['user_id'])
    post_id = Post.objects.get(id = request.POST['post_id'])
    Comment.objects.create(comment = request.POST['comment'], user_id = user_id, post_id = post_id)

    return redirect('/user_wall')
