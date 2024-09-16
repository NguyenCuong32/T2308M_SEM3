# List
def listexample():
    print("List example")
    list_exp = [1,2,3]
    print(f"List int {list_exp}")
    print(f"The first {list_exp[0]}")
    print(f"The last {list_exp[-1]}") # Khuyến khích
    print(f"The last {list_exp[2]}")
    list_str = ["Xin chao","cac ban"]
    print(f"List string {list_str}")
    list_mix = ["Xin chao","Cac ban", 123] # Khác biệt với C#, Java ...
    print(f"List mix {list_mix}")

def list_example_01():
    list_exp = [1,2,3]
    print(f"Lenght: {len(list_exp)}")
    for i in list_exp:
        print(f"Element i {i} ")
def list_example_02():
    print("While loop")
    list_exp = [100,20,333]
    i = 0
    while(i<len(list_exp)):
        print(f"Element i {i} = {list_exp[i]}")
        i = i+1

def list_example_03():
    list_exp = [100,20,333,100]
    num = int(input("Enter a number: "))
    num_ins = int(input("Enter a number: "))
    list_exp.append(num)
    list_exp.insert(1,num_ins)
    for i in list_exp:
        print(f"Element i {i} ")
    print(f"Count :{list_exp.count(100)}")

if __name__ == "__main__":
    listexample()
    list_example_01()
    list_example_02()
    list_example_03()