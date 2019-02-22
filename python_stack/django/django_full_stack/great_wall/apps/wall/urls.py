from django.conf.urls import url
from . import views

urlpatterns = [
    url(r'^user_wall$', views.show_wall),
    url(r'^logout$', views.logout),
    url(r'^make_post$', views.make_post),
    url(r'^make_comment$', views.make_comment),
]