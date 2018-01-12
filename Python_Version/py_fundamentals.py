# Program equivalent to C# fundamentals containing for loop, while loop, random, and fizzbuzz algo

list1 = [1,4,5,6,100]
for num in list1:
    print num  

i = 0
while i< len(list1):
    print list1[i]

for num in range(1,101):
    if num%3==0 and num%5!=0:
        print "fizz"
    if num%3!=0 and num%5==0:
      print "buzz"
    if num % 3 == 0 and num % 5 == 0:
        print "fizzbuzz"


for num in range(1, 101):
    if num % 3 == 0 :
        print "fizz"
    if num % 5 == 0:
      print "buzz"
    if num % 3 == 0 and num % 5 == 0:
        print "fizzbuzz"
