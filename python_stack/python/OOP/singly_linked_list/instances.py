from sl_node import Node
from sl_list import SList



my_list = SList()  # create a new instance of a list chaining, yeah!
my_list.add_to_front("are").add_to_front("Linked lists").add_to_back(
    "fun!").print_values()  # chaining yea!
# output should be:
# Linked lists
# are
# fun!
