class Products:
    def __init__(self, name, price, category):
        self.name = name
        self.price = price
        self.category = category


    def update_price(self, percent_change, is_increased):
        if is_increased == True:
            self.price = self.price * (percent_change / 100)
        if is_increased == False:
            self.price = self.price / (percent_change / 100)
        return self

    def print_info(self):
        print(f"Product Name: {self.name}")
        print(f"Product Price ${self.price}")
        print(f"Product Category: {self.category}")