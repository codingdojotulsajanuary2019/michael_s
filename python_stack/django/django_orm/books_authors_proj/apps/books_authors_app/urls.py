from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.index),
    url(r'^add_book$', views.add_book),
    url(r'^delete_book/(?P<id>\d+)$', views.delete_book),
    url(r'^view_book/(?P<id>\d+)$', views.view_book),
    url(r'^add_author_to_book/(?P<id>\d+)$', views.add_author_to_book),
    url(r'^authors$', views.show_authors),
    url(r'^add_author$', views.add_author),
    url(r'^show_authors$', views.show_authors),
    url(r'^delete_author/(?P<id>\d+)$', views.delete_author),
    url(r'^view_author/(?P<id>\d+)$', views.view_author),
    url(r'^add_book_to_author/(?P<id>\d+)$', views.add_book_to_author),
]