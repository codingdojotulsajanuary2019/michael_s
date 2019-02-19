from django.db import models

class Book(models.Model):
     title = models.CharField(max_length = 255)
     description = models.TextField()
     created_at = models.DateTimeField (auto_now_add=True)
     updated_at = models.DateTimeField (auto_now=True)

     def __repr__(self):
        return f"id: {self.id}, Title: {self.title}, Description:  {self.description}, Created At: {self.created_at}, Updated At: {self.updated_at} "

class Author(models.Model):
    first_name = models.CharField(max_length = 45)
    last_name = models.CharField(max_length = 45)
    books = models.ManyToManyField(Book, related_name = "authors")
    notes = models.TextField()
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    def __repr__(self):
        return f"id: {self.id}, First Name: {self.first_name}, Last Name:  {self.last_name}, Notes: {self.notes}, Created At: {self.created_at}, Updated At: {self.updated_at} "

    
