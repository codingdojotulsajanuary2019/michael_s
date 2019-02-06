class Animals:
    def __init__ (self, name, age, fur, legs, group):
        self.name = name
        self.age = age
        self.fur = fur
        self.legs = legs
        self.group = group

    def eats_bananas(self):
        print(f"{self.name} EATS BANANAS")

        return self


monkey = Animals("Fred", 20, True, 2, "Mamal")

monkey.eats_bananas().eats_bananas()

