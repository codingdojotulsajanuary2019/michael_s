from django.db import models

class Users(models.Model):
    first_name = models.CharField(max_length = 255)
    last_name = models.CharField(max_length = 255)
    email_address = models.CharField(max_length = 255)
    age = models.IntegerField()
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)

    def __repr__(self):
        return f"id: {self.id}, First Name: {self.first_name}, Last Name:  {self.last_name}, Email: {self.email_address}, Created At: {self.created_at}, Updated At: {self.updated_at} "




