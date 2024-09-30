def iterator_example():
    numbers = [1,4,556,67]
    numbers_iter = iter(numbers)
    print(next(numbers_iter))
    print(next(numbers_iter))
    print(next(numbers_iter))
def iterator_example_01():
    numbers = [1,4,556,67]
    numbers_iter = iter(numbers)
    for i in numbers_iter:
        print(f"loop iterator {i}")

if __name__ == "__main__":
    iterator_example()
    iterator_example_01()