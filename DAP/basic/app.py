from email.policy import default
from random import choice
from unittest import result


print ('Hello world')
# Comment
# Tạo hàm và gọi hàm trong Python
def summary(a,b):
    total = a+b
    print(f"Summary 2 numbers: {total}")
def summary_array():
    total =0
    for i in range(10):
        total_temp =total
        total = total_temp+i
        print(f"Summary position {i}: {total_temp} + {i} ={total}")
    print(f"Summary an array: {total}")
def div(a,b):
    result = a/b
    print(f"Div 2 numbers: {result}")
def sub(a,b):
    result = a-b
    print(f"Sub 2 numbers: {result}")
def mul(a,b):
    result = a*b
    print(f"Multiplation: {result}")
def loop_example():
    for i in range(10,0,-1):
        print(f"i = {i}")

def loop_example_01():
    x=0
    while (x <10):
        # x= x+1
        print(f"x ={x}")
    print(f"End loop")
def loop_example_02(x):
    match x:
        case 1:
            print(f"One")
        case 2:
            print(f"Two")
        case _:
            print(f"Default")
def menu():
        while True:
            try:
                choice = int(input("Enter a choice: "))
                a = int(input("Enter a number: "))
                b = int(input("Enter b number: "))
                print(f"choice: {choice}")
                if(choice == 1):
                    summary(a,b)
                elif(choice ==2):
                    div(a,b)
                elif(choice ==3):
                    sub(a,b)
                elif(choice==4):
                    mul(a,b)
                elif(choice==5):
                    summary_array()
                elif(choice ==6):
                    loop_example()
                elif(choice ==7):
                    loop_example_01()
                elif (choice ==8):
                    loop_example_02(a)
                else:
                    print("Please choice from 1 to 4")
                    break
            except:
                print("Only enter a number")   
         

if __name__ == "__main__":
    menu()