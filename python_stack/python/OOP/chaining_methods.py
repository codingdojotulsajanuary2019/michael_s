class User:
    def __init__(self, name, email):
        self.name = name
        self.email = email
        self.account_balance = 0

    # adding the deposit method

    def make_deposit(self, amount):  # takes an argument that is the amount of the deposit
        # the specific user's account increases by the amount of the value received
        self.account_balance += amount

        return self

    def make_withdrawl(self, amount):
        # the specific user's account decreases by the amount of the value received
        self.account_balance -= amount

        return self

    def display_user_balance(self):
        print("User: ", self.name)
        print("Balance:", self.account_balance, "\n")

        return self

    def transfer_money(self, giveToUser, amount):
        self.account_balance -= amount
        giveToUser.account_balance += amount
        print("Giving", giveToUser.name, amount, "Dollars", "\n")

        return self


Michael = User("Michael", "MichaelShea1814@gmail.com")
Ali = User("Ali", "Ali1124@gmail.com")
Patrick = User("Patrick", "Patrick7298@gmail.com")

Michael.make_deposit(100).make_deposit(50).make_deposit(37).make_withdrawl(22).display_user_balance()
Ali.make_deposit(75).make_deposit(48).make_withdrawl(25).make_withdrawl(25).display_user_balance()
Patrick.make_deposit(50).make_withdrawl(25).make_withdrawl(25).make_withdrawl(25).display_user_balance()
Michael.transfer_money(Ali, 25).display_user_balance()
Ali.display_user_balance()
