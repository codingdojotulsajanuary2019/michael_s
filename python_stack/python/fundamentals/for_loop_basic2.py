# Biggie Size - Given a list, write a function that changes all positive numbers in the list to "big".
# Example: biggie_size([-1, 3, 5, -5]) returns that same list, but whose values are now[-1, "big", "big", -5]


def biggieSize(list):
    for i in range(len(list)):
        if list[i] > 0:
            list[i] = "BIG"
    return list

x = biggieSize([-1,3,5,-5])
print(x)

# Count Positives - Given a list of numbers, create a function to replace the last value with the number of positive values. (Note that zero is not considered to be a positive number).
# Example: count_positives([-1, 1, 1, 1]) changes the original list to[-1, 1, 1, 3] and returns it
# Example: count_positives([1, 6, -4, -2, -7, -2]) changes the list to[1, 6, -4, -2, -7, 2] and returns it


def countPositives(list):
    count = 0

    for i in range(len(list)):
        if list[i] > 0:
            count += 1

    list[len(list)-1] = count

    return list

z = countPositives([-1,1,1,1])
print(z)


# Sum Total - Create a function that takes a list and returns the sum of all the values in the array.
# Example: sum_total([1, 2, 3, 4]) should return 10
# Example: sum_total([6, 3, -2]) should return 7


def sumTotal(list):
    sum = 0

    for i in range(len(list)):
        sum += list[i]

    return sum

total = sumTotal([1,2,3,4])
print(total)


# Average - Create a function that takes a list and returns the average of all the values.
# Example: average([1, 2, 3, 4]) should return 2.5

def avg(list):
    sum = 0

    for x in range(len(list)):
        sum += list[x]

    return sum/len(list)

z = avg([1,2,3,4])
print(z)


# Length - Create a function that takes a list and returns the length of the list.
# Example: length([37, 2, 1, -9]) should return 4
# Example: length([]) should return 0

def length(list):

        return len(list)

q = length([1,2,3,4,5])
print(q)


# Minimum - Create a function that takes a list of numbers and returns the minimum value in the list. If the list is empty, have the function return False.
# Example: minimum([37, 2, 1, -9]) should return -9
# Example: minimum([]) should return False

def minimum(list):
    minNum = list[0]

    if len(list) < 1:
        return False

    else:
        for i in range(len(list)):
            if list[i] < minNum:
                minNum = list[i]
    
    return minNum

m = minimum([37,2,1,-9])
print(m)


def maximum(list):
    maxNum = list[0]

    if len(list) < 1:
        return False
    else:
        for i in range(len(list)):
            if list[i] > maxNum:
                maxNum = list[i]

    return maxNum

j = maximum([37,2,1,-9])
print(j)


# Ultimate Analysis - Create a function that takes a list and returns a dictionary that has the sumTotal, average, minimum, maximum and length of the list.
# Example: ultimate_analysis([37, 2, 1, -9]) should return {'sumTotal': 31, 'average': 7.75, 'minimum': -9, 'maximum': 37, 'length': 4}


def ultimateAnalysis(list):
    total = 0
    minNum = list[0]
    maxNum = list[0]

    for i in range(len(list)):
        total += list[i]
         
        if list[i] < minNum:
            minNum = list[i]
        if list[i] > maxNum:
            maxNum = list[i]

    avg = total/len(list)
    
    dictionary = {
        'sumTotal': total,
        'average': avg,
        'minimum': minNum,
        'maximum': maxNum,
    }

    return dictionary

dictupdate = ultimateAnalysis([37,2,1,-9])
print(dictupdate)


# Reverse List - Create a function that takes a list and return that list with values reversed. Do this without creating a second list.
#  (This challenge is known to appear during basic technical interviews.)
# Example: reverse_list([37, 2, 1, -9]) should return [-9, 1, 2, 37]

def reverseList(list):
    for x in range(int(len(list)/2)):
        temp = list[x]
        list[x] = list[len(list)-x-1]
        list[len(list)-x-1] = temp

    return list

s = reverseList([37,2,1,-9])
print(s)

