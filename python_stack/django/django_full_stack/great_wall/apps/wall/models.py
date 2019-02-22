from django.db import models
from apps.login_register.models import User
import datetime

class Post(models.Model):
    user_id = models.ForeignKey(User, related_name = "post_user")
    message = models.TextField()
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)

class Comment(models.Model):
    post_id = models.ForeignKey(Post, related_name="post")
    user_id = models.ForeignKey(User, related_name = "comment_user")
    comment = models.TextField()
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)



