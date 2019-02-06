from products import Products

class Store:
    def __init__(self, name):
        self.name = name 
        self.products = []

    def add_product(self, new_product):
        self.products.append(new_product)

        return self

    def sell_product(self, id):
        self.products.remove(self.products[id])

        return self

    def inflation(self, percent_increase):
        self.products.price = Products.update_price(percent_increase, True)

    def set_clearance(self, category, percent_discount):
        pass
    


myStore = Store("Michael's Store")
myShirt = Products("Shirt", 30, "Top")
myPants = Products("Jeans", 50, "Bottoms")
myHat = Products("Hat", 25, " Hat")

myStore.add_product(myShirt).add_product(myPants).add_product(myHat)
myStore.sell_product(0)
myStore.inflation(10)

# print(myStore.products)

def print_products_list():
    for product_list in myStore.products:
        print(product_list.name, product_list.price, product_list.category)
print_products_list()


