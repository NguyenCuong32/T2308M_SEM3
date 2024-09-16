def tuple_example():
    print("Tuple example")
    tuple_exp = (1,2,3)
    print(f"Tuple {tuple_exp}")
    for i in tuple_exp:
        print(f"Element i {i}")
    tuple_exp_mix = ("Xin chao","cac ban", 123)
    print(f"Tuple mix {tuple_exp_mix}")

def tuple_example_01():
    tuple_exp = (1,2,3,1)
    print(f"Count: {tuple_exp.count(1)}" ) 
if __name__ == "__main__":
    tuple_example()
    tuple_example_01()