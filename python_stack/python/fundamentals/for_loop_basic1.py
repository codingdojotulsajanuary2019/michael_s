# print all integers from 0 to 150

for x in range(151):
    print(x)


# Print all the multiples of 5 from 5 to 1,000

for i in range(5,1001,5):
    print(i)


#Print integers 1 to 100. if divisible by 5, print "Coding" instead. If divisble by 10, print "Coding Dojo"

for i in range(101):
    if i % 5 == 0:
        print("Coding")
    if i % 10 == 0:
        print("Coding Dojo")
    else:
        print(i)


# add odd integers from 0 to 500,000 and print the final sum 

sum = 0

for i in range(1,500001,2):
    sum += i

print(sum)


# print postive numbers starting at 2018, counting down by fours. 

for i in range(2018, 0, -4):
    print(i)

# Set three variables: lowNum, highNum, mult. 
# Starting at lowNum and going through highNum, print only the integers that are a multiple of mult.
#  For example, if lowNum = 2, highNum = 9, and mult = 3, the loop should print 3, 6, 9 (on successive lines)

lowNum = 2
highNum = 9
mult = 3

for i in range(lowNum,highNum+1,1):
    if i % mult == 0:
        print(i)
