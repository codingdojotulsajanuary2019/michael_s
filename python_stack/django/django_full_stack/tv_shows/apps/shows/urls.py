from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^$', views.allshows),
    url(r'^shows/new$', views.show_add_show),
    url(r'^new/add$', views.add_new_show),
    url(r'^shows/(?P<id>\d+)$', views.show_show),
    url(r'^shows/(?P<id>\d+)/edit$', views.show_edit_show),
    url(r'^show/(?P<id>\d+)/update$', views.update_show),
    url(r'^show/(?P<id>\d+)/delete$', views.delete_show),
    
]