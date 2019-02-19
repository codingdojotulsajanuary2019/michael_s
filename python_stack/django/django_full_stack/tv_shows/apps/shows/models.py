from django.db import models

class Shows(models.Model):
    title = models.CharField(max_length = 255)
    network = models.CharField(max_length = 255)
    release_date = models.DateField()
    description = models.TextField()
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)

    def __repr__(self):
        return f"id: {self.id}, Title: {self.title}, Network:  {self.network}, Release Date: {self.release_date}, Description: {self.description}, Created At: {self.created_at}, Updated At: {self.updated_at} "
