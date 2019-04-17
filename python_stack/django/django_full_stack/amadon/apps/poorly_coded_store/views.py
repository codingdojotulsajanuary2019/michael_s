from django.shortcuts import render, redirect
from .models import Order, Product

def index(request):
    context = {
        "all_products": Product.objects.all()
    }
    return render(request, "store/index.html", context)

def process(request):

    quantity_from_form = int(request.POST["quantity"])
    price_from_form = float(request.POST["price"])
    total_charge = quantity_from_form * price_from_form

    if 'quantity' not in request.session:
        request.session['quantity'] = quantity_from_form
    else:
        request.session['quantity'] += quantity_from_form

    if 'total_spent' not in request.session:
        request.session['total_spent'] = total_charge
    else:
        request.session['total_spent'] += total_charge

    request.session['total_quantity'] = quantity_from_form
    request.session['prod_id'] = request.POST['product_id']

    print("Charging credit card...")
    Order.objects.create(quantity_ordered=quantity_from_form, total_price=total_charge)
    return redirect('/checkout')

def checkout(request):
    prod_id = int(request.session['prod_id'])
    product = Product.objects.get(id = prod_id)
    quantity = request.session['total_quantity']
    total_charge = product.price * quantity

    context = {'total_charge':total_charge}

    

    return render(request,"store/checkout.html", context )