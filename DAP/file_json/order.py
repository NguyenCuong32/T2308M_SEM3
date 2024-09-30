from pydantic import BaseModel

class Address(BaseModel):
    street:str
    city:str
    state:str
    postalCode:str
    country:str

class Customer(BaseModel):
     customerId: str
     name:str
     email:str
     phone:str
     address:Address
class Order(BaseModel):
     orderId:str
     customer:Customer