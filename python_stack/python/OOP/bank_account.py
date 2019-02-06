class BankAccount:
    def __init__(self, accNum, balance1=0, balance2=0, interestRate=2):
        self.accNum = accNum
        self.balance1 = balance1
        self.balance2 = balance2
        self.interestRate = interestRate / 100

    # def deposit(self, amount):
    #     self.balance += amount

    #     return self

    
    # def withdraw(self, amount):
    #     self.balance -= amount

    #     return self


    def display_account_info(self):
        print(f"Balance: $ {self.balance}")
        print(f"Your current interest rate is {self.interestRate * 100}%")

        return self


    def yield_interest(self):
        if self.balance > 0:
            self.balance = self.balance + (self.balance * self.interestRate)
            print(f"After gaining interest your new balance is ${self.balance}")
        if self.balance <= 0:
            print(f"Your current blance of ${self.balance} is too low to gain interest")

        return self



# account1 = BankAccount(100, 3)
# account2 = BankAccount(500, 6)

# account1.deposit(25).deposit(25).deposit(25).withdraw(40).yield_interest().display_account_info()
# account2.deposit(55).deposit(42).withdraw(15).withdraw(20).withdraw(100).withdraw(22).yield_interest().display_account_info()


class User:
    def __init__(self, name, email):
        self.name = name
        self.email = email
        self.account = BankAccount(accNum=1, balance1=0, balance2=0, interestRate=2)

    # adding the deposit method

    def make_deposit(self, accNum, amount):  # takes an argument that is the amount of the deposit
        # the specific user's account increases by the amount of the value received
        if accNum == 1:
            self.account.balance1 += amount
        if accNum == 2:
            self.account.balance2 += amount
        return self

    def make_withdrawl(self, accNum, amount):
        # the specific user's account decreases by the amount of the value received
        if accNum == 1:
            self.account.balance1 -= amount
        if accNum == 2:
            self.account.balance2 -=  amount

        return self

    def display_user_balance(self, accNum):
        print(f"User: {self.name}")
        if accNum == 1:
            print(f"Account 1 Balance: ${self.account.balance1} \n")
        if accNum == 2:
            print(f"Account 2 Balance: ${self.account.balance2} \n ")

        return self

    def transfer_money(self, giveToUser, amount):
        self.account.balance -= amount
        giveToUser.account.balance += amount
        print("Giving", giveToUser.name, amount, "Dollars", "\n")

        return self


Michael = User("Michael", "MichaelShea1814@gmail.com")
Ali = User("Ali", "Ali1124@gmail.com")
Patrick = User("Patrick", "Patrick7298@gmail.com")

# Michael.make_deposit(200).make_deposit(20).make_withdrawl(2).display_user_balance()

Michael.make_deposit(1, 200).display_user_balance(1).make_withdrawl(1,22).display_user_balance(1)
Michael.make_deposit(2, 75).display_user_balance(2).make_withdrawl(2,59).display_user_balance(2)


