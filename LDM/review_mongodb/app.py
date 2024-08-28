from http import client
from pydoc import doc
from random import choice
from pymongo import MongoClient

connection_string ="mongodb://root:123456@127.0.0.1:27017/"
client = MongoClient(connection_string)
db = client["SystemInformationStudent"]
collection_role = db["Role"]

def addRole():
    id = input("Please enter id: ")
    role_name = input("Please enter role name")
    is_active = True
    doc = {"id":id,"role_name":role_name,"is_active":is_active}
    collection_role.insert_one(doc)
    print("Inserted")

def menu():
    while(True):
        choice = input("Please enter a number: ")
        if choice == "1":
            print("Demo Insert")
            addRole()
          
        
        
    

if __name__ == "__main__":
    menu()
