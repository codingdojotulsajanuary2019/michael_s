from django.db import models
import datetime


class ShowManager(models.Manager):
    def show_vaildator(self, postData):
        errors = {}

        if len(postData['showtitle']) < 2:
            errors['showtitle'] = "Title should be at least 2 Characters Long"
        if len(postData['shownetwork']) < 1:
            errors['shownetwork'] = "Field cannot be empty"
        if len(postData['showdescription']) < 10:
            errors['showdescription'] = "Show Description must be longer than 10 characters"

        return errors

class Shows(models.Model):
    title = models.CharField(max_length = 255)
    network = models.CharField(max_length = 255)
    release_date = models.DateField()
    description = models.TextField()
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)

    objects = ShowManager()

    def __repr__(self):
        return f"id: {self.id}, Title: {self.title}, Network:  {self.network}, Release Date: {self.release_date}, Description: {self.description}, Created At: {self.created_at}, Updated At: {self.updated_at} "



