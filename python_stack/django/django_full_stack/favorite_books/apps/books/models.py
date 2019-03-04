from django.db import models
from apps.login_register.models import User

class Book(models.Model):
    title = models.CharField(max_length = 255)
    description = models.TextField()
    created_at = models.DateTimeField(auto_now_add = True)
    updatd_at = models.DateTimeField(auto_now = True)
    uploaded_by = models.ForeignKey(User, related_name = "books_uploaded")
    users_who_like = models.ManyToManyField(User, related_name = "liked_books")



