def dict_example():
    person = [{
        "name": "Nguyen Van A",
        "age":20,
        "address":"Ha noi"
    },
    {
        "name": "Nguyen Van B",
        "age":25,
        "address":"Ha nam"
    }
    ]
    print(person)
    print(f"Ten nguoi: {person[1]["name"]}")
if __name__ == "__main__":
    dict_example()
