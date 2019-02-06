from sl_node import Node

class SList:
    def __init__(self):
        self.head = None

    def add_to_front(self, val):        # Added this line, takes a value
        new_node = Node(val)            # Create a new instance of our node class using the given value.
        current_head = self.head        # Save the current head in a variable
        new_node.next = current_head    # SET the new node's next TO the list's current head
        self.head = new_node            # SET the list's head TO the node we created in the last step
        return self                     # Return self to allow for chaining

    def add_to_back(self, val):         # accepts a value
        if self.head == None:           # if the list is empty
            self.add_to_front(val)      # run the add_to_front method
            return self                 # let's make sure the rest of this function doesn't happen if we add to the front.

        new_node = Node(val)            # create a new instance of our Node class with the give value
        runner = self.head              # set an iterator ro start at the front of the list 
        while (runner.next != None):    # iterator until the iterator doesn't have a neighbor
            runner = runner.next        # incrememnt the runner to the next node in the list 
        runner.next = new_node          # increment the runner to the next node in the list 
        return self                     # return self to allow for chaining

    def print_values(self):
        runner = self.head              # A pointer to the list's first node
        while(runner != None):          # Iterating while runner is a node and not None
            print(runner.value)         # Print the current node's value
            runner = runner.next        # Set the runner to it's neighbor
        return self                     # Once the loop is done, return self to allow for chainning 

    def remove_from_front(self):
        if self.head == None:
            return self

        self.head = self.head.next
        return self

    def remove_from_back(self):
        if self.head == None:
            return self

        runner = self.head
        while(runner.next.next != 0):
            runner = runner.next
        runner.next = None
        return self

    def remove_val(self, val):
        if self.head.value == val:
            self.head = self.head.next
            return self

        runner = self.head
        while (runner.next.value != val):
            runner = runner.next
        runner.next = runner.next.next
        return self

    def insert_at(self, val, n):
        if n== 0:
            new_node = Node(val)
            new_node.next = self.head
            self.head = new_node
            return self
        
        i = 1
        runner = self.head
        while i < n:
            runner = runner.next
            i+=1
        new_node = Node(val)
        new_node.next = runner.next
        runner.next - new_node
        return self

