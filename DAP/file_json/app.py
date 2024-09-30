import json
from os import path, write
from order import Customer,Order,Address

def readFileJson(path):
    if path is not None:
        with open(path,'r') as content:
            order = json.load(content)
            print(order["orderId"])
def writeFileJson(order,path):
    if path is not None:
        with open(path,'w') as file:
            json.dump(order.dict(),file,indent=4)

def convertJsonToObject(path):
    if path is not None:
        with open(path,'r') as content:
            json_data = json.load(content)
        
        order = Order(**json_data)
        print(order.orderId)


if __name__ == "__main__":
    path ="./order.json"
    order = Order(
        orderId ="100",
        customer = Customer(
            customerId="15",
            name="Anh",
            email="cuong@gmail.com",
            phone="+84988999",
            address = Address(
                street="Ha noi",
                city="HN",
                state="HN",
                postalCode="10000",
                country="VN"
            )
        )
    )
    writeFileJson(order,path)
    readFileJson(path)
    convertJsonToObject(path)