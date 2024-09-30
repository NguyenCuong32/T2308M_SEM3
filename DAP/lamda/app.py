plus = lambda a,b: a+b
if __name__ == "__main__":
    print(f"Plus a + b = {plus(2,3)}")

# Đề bài cho chuỗi số hãy tìm và in ra các số chan
# C1:
def evenNumber():
    numbers = [1,2,5,11,6,8,9,3]
    for i in numbers:
        if (i%2==0):
            print(f"So chan: {i}")



if __name__ == "__main__":
    evenNumber()
    # C2:
    numbers = [1,2,5,11,6,8,9,3]
    evenNum = list(filter(lambda x:x%2 ==0,numbers))
    print(evenNum)
    sort = list(sorted(numbers,key=lambda x:x))
    print(f"Order asc {sort}")
    sort_desc = list(sorted(numbers,key= lambda x:x,reverse=True))
    print(f"Order desc {sort_desc}")
    # Sort 


